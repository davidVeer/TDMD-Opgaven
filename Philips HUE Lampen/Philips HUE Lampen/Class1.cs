﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips_HUE_Lampen
{
    public class State
    {
        public int[] xy { get; set; }
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

}
