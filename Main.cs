using Open.Nat;
using System.Net;
using System.Net.NetworkInformation;

namespace Rupee
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private readonly int startingPort = 45000, endingPort = 65536;

        private int PublicPortUsed = 0, PrivatePortUsed = 0;

        private int myTime = 86400;
        private DateTime startTime;

        bool gotMyIP = false;

        private List<int> PortsAlreadyUsed = new();

        private Protocol protocolUsed = Protocol.Udp;

        private Mapping myMap = new(Protocol.Udp, 0, 0);

        private readonly NatDiscoverer discoverer = new();

        private void Main_Load(object sender, EventArgs e)
        {
            NewPublicPort.Enabled = false;
            ShowAO.Enabled = false;
            GBAO.Enabled = false;
            OpenPort.Enabled = false;
            ClosePort.Enabled = false;

            UDPRadioButton.Checked = true;

            Task.Run(async () =>
            {
                NatDevice myDevice = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, new CancellationTokenSource(10000));

                IPAddress ip = IPAddress.Parse("127.0.0.1");

                //Récupérer IP publique
                while (!gotMyIP)
                {
                    ip = await myDevice.GetExternalIPAsync();
                    if (IPAddress.TryParse(ip.ToString(), out var ipAddress))
                        gotMyIP = true;
                }

                //Scanner les ports dispos
                IEnumerable<Mapping> mappings = await myDevice.GetAllMappingsAsync();

                List<Mapping> maps = mappings.ToList();

                for (int i = 0; i < maps.Count; i++)
                {
                    PortsAlreadyUsed.Add(maps[i].PublicPort);
                }

                List<IPEndPoint> tcpPorts = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners().ToList();
                List<IPEndPoint> udpPorts = IPGlobalProperties.GetIPGlobalProperties().GetActiveUdpListeners().ToList();

                //UDP
                for (int i = 0; i < udpPorts.Count; i++)
                {
                    PortsAlreadyUsed.Add(udpPorts[i].Port);
                }

                //TCP
                for (int i = 0; i < tcpPorts.Count; i++)
                {
                    PortsAlreadyUsed.Add(tcpPorts[i].Port);
                }

                PortsAlreadyUsed = PortsAlreadyUsed.Distinct().ToList();

                PublicPortUsed = RandomPort();
                PrivatePortUsed = RandomPort();

                Invoke(new Action(() =>
                {
                    NewPublicPort.Enabled = true;
                    ShowAO.Enabled = true;
                    OpenPort.Enabled = true;

                    MyIp.Text = ip.ToString();

                    PublicPort.Text = PublicPortUsed.ToString();
                    PrivatePort.Text = PrivatePortUsed.ToString();
                }));
            });
        }

        private void ShowAO_CheckedChanged(object sender, EventArgs e)
        {
            if (GBAO.Enabled == false)
            {
                GBAO.Enabled = true;
                PublicPort.ReadOnly = false;
            }
            else
            {
                GBAO.Enabled = false;
                protocolUsed = Protocol.Udp;
                UDPRadioButton.Checked = true;
                setHours.Value = 24;
                setMinutes.Value = 0;
                setSeconds.Value = 0;
                PublicPort.ReadOnly = true;
            }
        }

        private void NewPublicPort_Click(object sender, EventArgs e)
        {
            if (ShowAO.Checked)
            {
                PublicPortUsed = RandomPort();
                PublicPort.Text = PublicPortUsed.ToString();
            }
            else
            {
                PublicPortUsed = RandomPort();
                PrivatePortUsed = RandomPort();

                PublicPort.Text = PublicPortUsed.ToString();
                PrivatePort.Text = PrivatePortUsed.ToString();
            }
        }

        private void NewPrivatePort_Click(object sender, EventArgs e)
        {
            PrivatePortUsed = RandomPort();
            PrivatePort.Text = PrivatePortUsed.ToString();
        }

        private int RandomPort()
        {
            var range = Enumerable.Range(startingPort, endingPort).Where(i => !PortsAlreadyUsed.Contains(i)).Where(i => !PublicPortUsed.Equals(i)).Where(i => !PrivatePortUsed.Equals(i));

            int index = new Random().Next(1, 20536 - PortsAlreadyUsed.Count);
            return range.ElementAt(index);
        }

        private void TCPRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TCPRadioButton.Checked)
                protocolUsed = Protocol.Tcp;
        }

        private void UDPRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UDPRadioButton.Checked)
                protocolUsed = Protocol.Udp;
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            if (PrivatePort.Text.Length >= 4 && int.Parse(PrivatePort.Text) >= startingPort && int.Parse(PrivatePort.Text) < endingPort && int.Parse(PublicPort.Text) > startingPort && int.Parse(PublicPort.Text) < endingPort)
            {
                if (ShowAO.Checked)
                {
                    myTime = (int)((setHours.Value * 60 * 60) + (setMinutes.Value * 60) + setSeconds.Value);

                    if (myTime > 86400)
                        myTime = 86400;
                }

                Task.Run(async () =>
                {
                    NatDevice myDevice = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, new CancellationTokenSource(10000));
                    myMap = new(protocolUsed, IPAddress.None, PrivatePortUsed, PublicPortUsed, myTime, "Rupee");
                    await myDevice.CreatePortMapAsync(myMap); //Création de la redirection
                });

                startTime = DateTime.Now;
                RupeeTimer.Start();

                OpenPort.Enabled = false;
                ClosePort.Enabled = true;

                PublicPort.ReadOnly = true;
                NewPublicPort.Enabled = false;

                PrivatePort.ReadOnly = true;
                NewPrivatePort.Enabled = false;

                UDPRadioButton.Enabled = false;
                TCPRadioButton.Enabled = false;

                setHours.Enabled = false;
                setMinutes.Enabled = false;
                setSeconds.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("The port must be between {0}, and {1}", startingPort, endingPort), "Error");
            }
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            StopPort();
        }

        private void StopPort()
        {
            RupeeTimer.Stop();
            RemainingTime.Text = "00:00:00";

            Task.Run(async () =>
            {
                NatDevice myDevice = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, new CancellationTokenSource(10000));
                await myDevice.DeletePortMapAsync(myMap);
            });

            OpenPort.Enabled = true;
            ClosePort.Enabled = false;

            if (ShowAO.Checked)
                PublicPort.ReadOnly = false;

            NewPublicPort.Enabled = true;

            PrivatePort.ReadOnly = false;
            NewPrivatePort.Enabled = true;

            UDPRadioButton.Enabled = true;
            TCPRadioButton.Enabled = true;

            setHours.Enabled = true;
            setMinutes.Enabled = true;
            setSeconds.Enabled = true;
        }

        private void RupeeTimer_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = myTime - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                StopPort();
            }

            TimeSpan t = TimeSpan.FromSeconds(remainingSeconds);

            RemainingTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds);
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopPort();
        }

        private void PrivatePort_TextChanged(object sender, EventArgs e)
        {

            PrivatePortUsed = int.Parse(PrivatePort.Text);
        }

        private void PublicPort_TextChanged(object sender, EventArgs e)
        {
            PublicPortUsed = int.Parse(PublicPort.Text);
        }

        private void PrivatePort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckChar(e);
        }

        private void PublicPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckChar(e);
        }

        private static bool CheckChar(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}