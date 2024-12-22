using System.Text.Json;

namespace Philips_HUE_Lampen {
    public static class APIConnection {
        public static string ConnectedApi_IpAdress { get; private set; }
        public static string ConnectedApi_Username { get; private set; }
        public static List<HueLight> LampList { get; set; }

        public static void ConnectToApi(string NewApi_IpAdress, string NewApi_Username) {
            ConnectedApi_IpAdress = NewApi_IpAdress;
            ConnectedApi_Username = NewApi_Username;
        }

        public static void InitializeList() {
            LampList = new List<HueLight>();
            int currentNumber = 1;
            while (true) {
                String SelectedLight = $"lights/{currentNumber}";

                try {
                    String response = Task.Run(async () => await API_Requests.SendHTTPRequestGet(SelectedLight)).Result;
                    HueLight newLight = JsonSerializer.Deserialize<HueLight>(response);
                    LampList.Add(newLight);
                } catch {
                    break;
                }

                currentNumber++;
            }
        }
    }
}
