using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips_HUE_Lampen
{
    internal class API_Requests
    {
        public static async Task SendHTTPRequestPut(string lampId, string jsonPayload)
        {
            HttpClient client = new HttpClient();
            try
            {
                string url = $"http://{APIConnection.ConnectedApi_IpAdress}/api/{APIConnection.ConnectedApi_Username}/lights/{lampId}/state";
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

        public static async Task<String> SendHTTPRequestGet(string jsonPayload)
        {
            HttpClient client = new HttpClient();
                string url = $"http://{APIConnection.ConnectedApi_IpAdress}/api/{APIConnection.ConnectedApi_Username}/{jsonPayload}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;     
        }

    }
}
