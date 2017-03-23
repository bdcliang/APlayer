using APlayer.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APlayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LLMainForm form = new LLMainForm();
            IController main = new MediaController(new View.APlayer(form.PlayerCore));
            main.LoadView(form);
            string logo = Application.StartupPath +@"\home.jpg";
            main.SetCustomLogo(logo);
            //Application.Run(form);
            main.Run();
        }
    }
}
