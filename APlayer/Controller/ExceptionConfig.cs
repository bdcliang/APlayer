using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace APlayer.Controller
{
    class ExceptionConfig
    {
        public static void Register()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "Application_ThreadException"+ "\r\n";
            Exception error = e.Exception as Exception;
            if (error != null)
                str = string.Format(strDateInfo + "Type：{0}\r\nMessage：{1}\r\nStackTrace：{2}\r\n", error.GetType().Name, error.Message, error.StackTrace);
            else
                str = string.Format("Application_ThreadException:{0}", e);
            writeLog(str);
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            Exception error = e.ExceptionObject as Exception;
            string strDateInfo = "CurrentDomainException：" + "\r\n";
            if (error != null)
                str = string.Format(strDateInfo + "Message:{0};\n\rStackTrace:{1}", error.Message, error.StackTrace);
            else
                str = string.Format("Application UnhandledError:{0}", e);
            writeLog(str);
        }
        private static void writeLog(string str)
        {
            using (StreamWriter sw = new StreamWriter(@"err.log", true))
            {
                sw.WriteLine("["+DateTime.Now.ToString()+"]");
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }
    }
}
