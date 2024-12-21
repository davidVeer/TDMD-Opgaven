
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Philips_HUE_Lampen
{
    public static class APIConnection
    {
        public static string ConnectedApi_IpAdress { get; private set; }
        public static string ConnectedApi_Username { get; private set; }
        public static List<Lightsobject> LampList { get; set; }

        public static void ConnectToApi(string NewApi_IpAdress, string NewApi_Username)
        {
            ConnectedApi_IpAdress = NewApi_IpAdress;
            ConnectedApi_Username = NewApi_Username;
        }

        public static void InitializeList()
        {
            LampList = new List<Lightsobject>();
            int currentNumber = 1;
            while (true)
            {
                String SelectedLight = $"lights/{currentNumber}";

                try
                {
                    String response = Task.Run(async () => await API_Requests.SendHTTPRequestGet(SelectedLight)).Result;
                    Lightsobject newLight = JsonSerializer.Deserialize<Lightsobject>(response);
                    LampList.Add(newLight);
                }
                catch {
                    break;
                }

                currentNumber++;
            }
        }
    }
}
