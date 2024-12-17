using System.Net.Http.Json;
using System.Text;

namespace Philips_HUE_Lampen
{
    public partial class Connection : ContentPage
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Task.Run(async ()=> SendHTTPRequest("localhost", "newdeveloper", "1" , "{\"on\": false}"));
        }

        public static async Task SendHTTPRequest(string bridgeIp, string username, string lampId, string jsonPayload)
        {
            HttpClient client = new HttpClient();
            try
            {
                string url = $"http://{bridgeIp}/api/{username}/lights/{lampId}/state";
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(url, content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {responseBody}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fout bij het versturen van het commando: {e.Message}");
            }
        }
    }
}
