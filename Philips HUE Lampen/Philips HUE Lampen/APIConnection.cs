
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips_HUE_Lampen
{
    public static class APIConnection
    {
        public static string ApiIp { get; set; }
        public static string Username { get; set; }
        public static List<Lamp> list { get; set; }

        public static void ConnectToApi(string apiIp, string username)
        {
            ApiIp = apiIp;
            Username = username;

        }

        public static List<Lamp> getLamps()
        {
            return list;
        }

        public static void setList()
        {
            list = new List<Lamp>();
            list.Add(new Lamp { id = "1", Brightness = "100", Hue = "100", Saturation = "100", Status = true});
            list.Add(new Lamp { id = "2", Brightness = "100", Hue = "100", Saturation = "100", Status = true});
            list.Add(new Lamp { id = "3", Brightness = "100", Hue = "100", Saturation = "100", Status = true});
            list.Add(new Lamp { id = "4", Brightness = "100", Hue = "100", Saturation = "100", Status = true});
            list.Add(new Lamp { id = "5", Brightness = "100", Hue = "100", Saturation = "100", Status = true});
        }
    }
}
