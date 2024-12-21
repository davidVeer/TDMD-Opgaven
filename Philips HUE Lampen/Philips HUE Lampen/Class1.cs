using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace Philips_HUE_Lampen
{
    public class Lightsobject
    {
        public string modelid { get; set; }
        public string name { get; set; }
        public string swversion { get; set; }
        public State state { get; set; }
        public string type { get; set; }
        public Pointsymbol pointsymbol { get; set; }
        public string uniqueid { get; set; }
    }

    public class State
    {
        public double[] xy { get; set; }
        public int ct { get; set; }
        public string alert { get; set; }
        public int sat { get; set; }
        public string effect { get; set; }
        public int bri { get; set; }
        public int hue { get; set; }
        public string colormode { get; set; }
        public bool reachable { get; set; }
        public bool on { get; set; }
    }

    public class Pointsymbol
    {
        public string _1 { get; set; }
        public string _2 { get; set; }
        public string _3 { get; set; }
        public string _4 { get; set; }
        public string _5 { get; set; }
        public string _6 { get; set; }
        public string _7 { get; set; }
        public string _8 { get; set; }
    }
}
