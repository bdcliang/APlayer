using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APlayer
{
    using APlayer.View;
    public partial class LLMainForm : Form
    {
        public LLMainForm()
        {
            InitializeComponent();
        }

        public AxAPlayer3Lib.AxPlayer PlayerCore { get { return this.axPlayer1; } }
    }
}
