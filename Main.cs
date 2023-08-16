using Open.Nat;
using System.Diagnostics;

namespace Rupee
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Coucou");
            int port = 9050; //Choisir un port inutilis�
            NatDiscoverer discoverer = new NatDiscoverer();
            CancellationTokenSource cts = new CancellationTokenSource(10000); //temps de validit� pour la redirection
            NatDevice device = await discoverer.DiscoverDeviceAsync(PortMapper.Upnp, cts); //Osef
            Mapping map = new(Protocol.Udp, port, port, "Test pour voir"); //Port public et priv�
            await device.CreatePortMapAsync(map); //Cr�ation de la redirection
            //await device.DeletePortMapAsync(map); //Suppression de la redirection
            Debug.WriteLine($"Created {map}"); //Infos du map
        }
    }
}