using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer.Model
{
    public class LightControl
    {
        public bool Enable { get; set; }
        public string Address { get; set; }
        public string NormState { get; set; }
        public List<string> Ports { get; set; }
        public string StrPorts { get; set; }
        public string RemoteIP { get; set; }
    }
}
