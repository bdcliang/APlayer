using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace APlayer.Model
{
    public class Setting
    {
        public Rectangle ClientRec { get; set; }
        public bool CirPlay { get; set; }
        public bool HideCur { get; set; }
        public bool TopMost { get; set; }

        public int Port { get; set; }
    }
}
