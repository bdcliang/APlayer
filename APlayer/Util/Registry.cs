namespace LLSDK.WinAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.Win32;
    using Reg = Microsoft.Win32.Registry;
    /// <summary>
    /// 注册表操作
    /// </summary>
    public class Registry
    {
        /// <summary>
        /// 向指定的程序名下的key写值
        /// </summary>
        /// <param name="AppName"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void RegWrite(string AppName, string key, string value)
        {
            try
            {
                string arguments = string.Format(@"SOFTWARE\BoRuiMultiMedia\{0}", AppName);
                RegistryKey reg = Reg.LocalMachine.OpenSubKey(arguments, true);
                if (null == reg) { reg = Reg.LocalMachine.CreateSubKey(arguments); }
                reg.SetValue(key, value); reg.Flush(); reg = null;
            }
            catch { return; }
        }
        /// <summary>
        /// 返回一个项下面的所有子项名称
        /// </summary>
        /// <param name="AppName"></param>
        /// <returns></returns>
        public static List<string> RegGetAllArgs(string AppName)
        {
            try
            {
                string arguments = string.Format(@"SOFTWARE\BoRuiMultiMedia\{0}", AppName);
                Dictionary<string, int> dic = new Dictionary<string, int>();
                RegistryKey reg = Reg.LocalMachine.OpenSubKey(arguments, true);
                if (null == reg) { reg = Reg.LocalMachine.CreateSubKey(arguments); }
                return new List<string>(reg.GetSubKeyNames());

            }
            catch { return null; }
        }
        /// <summary>
        /// 从注册表中取出指定程序下的Key值
        /// </summary>
        /// <param name="AppName">程序ming</param>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static string RegRead(string AppName, string key)
        {
            try
            {
                string arguments = string.Format(@"SOFTWARE\BoRuiMultiMedia\{0}", AppName);
                RegistryKey reg = Reg.LocalMachine.OpenSubKey(arguments, true);
                if (null == reg) { reg = Reg.LocalMachine.CreateSubKey(arguments); return ""; }
                return reg.GetValue(key) as string;
            }
            catch { return ""; }
        }

        /// <summary>
        /// 删除整个子项，@"SOFTWARE\BoRuiMultiMedia"
        /// </summary>
        /// <param name="AppName"></param>
        public static void RegRemove(string AppName)
        {
            try
            {
                string arguments = string.Format(@"SOFTWARE\BoRuiMultiMedia");
                RegistryKey reg = Reg.LocalMachine.OpenSubKey(arguments, true);
                if (null == reg) { return; }
                reg.DeleteSubKeyTree(AppName);
            }
            catch { return; }
        }
    }
}
