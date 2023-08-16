using Open.Nat;
using System.Diagnostics;
using System.Net;

namespace Rupee
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        bool gotMyIP = false;

        Protocol protocolUsed = Protocol.Udp;

        private void Main_Load(object sender, EventArgs e)
        {
            //Ne pas oublier de changer la taille de la fenetre en 535;260
            //et de masquer  les options avancées

            NewPublicPort.Enabled = false;
            ShowAO.Enabled = false;
            OpenPort.Enabled = false;
            ClosePort.Enabled = false;

            UDPRadioButton.Checked = true;

            Task.Run(async () =>
            {

                //Récupérer IP publique
                while (!gotMyIP)
                {
                    var externalIpString = (await new HttpClient().GetStringAsync("http://icanhazip.com"))
                        .Replace("\\r\\n", "").Replace("\\n", "").Trim();
                    if (IPAddress.TryParse(externalIpString, out var ipAddress))
                        gotMyIP = true;
                    Invoke(new Action(() =>
                    {
                        MyIp.Text = externalIpString;
                    }));
                }

                //Scanner les ports dispos

                Invoke(new Action(() =>
                {
                    NewPublicPort.Enabled = true;
                    ShowAO.Enabled = true;
                    OpenPort.Enabled = true;
                }));
            });
        }

        private void ShowAO_CheckedChanged(object sender, EventArgs e)
        {
            if (GBAO.Visible)
            {
                GBAO.Visible = false;
                PublicPort.ReadOnly = true;
                protocolUsed = Protocol.Udp;
                UDPRadioButton.Checked = true;
                this.Size = new Size(535, 220);
            }
            else
            {
                GBAO.Visible = true;
                PublicPort.ReadOnly = false;
                this.Size = new Size(535, 475);
            }
        }

        private void NewPublicPort_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Nouveau port public");
        }

        private void NewPrivatePort_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Nouveau port privé");
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

            if (ShowAO.Checked)
            {
                //Récupérer le temps de validité d'ouverture du port
            }

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

        private void ClosePort_Click(object sender, EventArgs e)
        {
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



        /*
         * Debug.WriteLine("Coucou");
            int port = 9050; //Choisir un port inutilisé
            NatDiscoverer discoverer = new NatDiscoverer();
            CancellationTokenSource cts = new CancellationTokenSource(10000); //temps de validité pour la redirection
            NatDevice device = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, cts); //Osef
            Mapping map = new(Protocol.Udp, port, port, "Test pour voir"); //Port public et privé
            await device.CreatePortMapAsync(map); //Création de la redirection
            //await device.DeletePortMapAsync(map); //Suppression de la redirection
            Debug.WriteLine($"Created {map}"); //Infos du map*/
    }
}