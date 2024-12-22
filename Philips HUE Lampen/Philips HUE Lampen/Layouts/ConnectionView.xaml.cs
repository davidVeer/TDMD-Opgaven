using System.Net.Http.Json;
using System.Text;

namespace Philips_HUE_Lampen
{
    public partial class Connection : ContentPage
    {
        private String developerUsername;

        public Connection()
        {
            InitializeComponent();
            developerUsername = "newdeveloper";
        }

        

        private void developerConnectButton_Clicked(object sender, EventArgs e)
        {
            APIConnection.ConnectToApi(ipAdressEntry.Text, developerUsername);
            APIConnection.InitializeList();
        }

        private void customBridgeConnectButton_Clicked(object sender, EventArgs e)
        {
            APIConnection.ConnectToApi(ipAdressEntry.Text, usernameEntry.Text);
            APIConnection.InitializeList();
        }

        private void previousBridgeConnectButton_Clicked(object sender, EventArgs e)
        {
            API_Requests.SendHTTPRequestPut("1" , "{\"on\": true}");
        }
    }
}
