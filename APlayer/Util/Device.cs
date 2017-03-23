namespace LLSDK.WinAPI
{
    using Microsoft.Win32;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using Reg = Microsoft.Win32.Registry;
    /// <summary>
    /// to control the device
    /// </summary>
    public class Device
    {
        #region   系统开关机操作

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetCurrentProcess();
        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
            ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool ExitWindowsEx(int flg, int rea);
        private const int SE_PRIVILEGE_ENABLED = 0x00000002;


        private const int TOKEN_QUERY = 0x00000008;
        private const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        private const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        #region Exit Windows Flags
        private const int EWX_LOGOFF = 0x00000000;
        private const int EWX_SHUTDOWN = 0x00000001;
        private const int EWX_REBOOT = 0x00000002;
        private const int EWX_FORCE = 0x00000004;
        private const int EWX_POWEROFF = 0x00000008;
        private const int EWX_FORCEIFHUNG = 0x00000010;
        #endregion

        private static void DoExitWin(int flg)
        {
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            if (!OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok))
            {
                throw new Exception("Open Process Token fail");
            }

            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            if (!LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid))
            {
                throw new Exception("Lookup Privilege Value fail");
            }
            if (!AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero))
            {
                throw new Exception("Adjust Token Privileges fail");
            }
            //Exit windows
            if (!ExitWindowsEx(flg, 0))
            {
                throw new Exception("Exit Windows fail");
            }
        }
        /// <summary>
        /// 重启
        /// </summary>
        /// <param name="force"></param>
        public static void Reboot(bool force)
        {
            if (force)
                DoExitWin(EWX_REBOOT | EWX_FORCE);
            else
                DoExitWin(EWX_REBOOT | EWX_FORCEIFHUNG);
        }
        /// <summary>
        /// 关机
        /// </summary>
        /// <param name="force"></param>
        public static void Shutdown(bool force)
        {
            if (force)
                DoExitWin(EWX_SHUTDOWN | EWX_FORCE);
            else
                DoExitWin(EWX_SHUTDOWN | EWX_FORCEIFHUNG);
        }
        /// <summary>
        /// logoff the computer
        /// </summary>
        /// <param name="force"></param>
        public static void Logoff(bool force)
        {
            if (force)
                DoExitWin(EWX_LOGOFF | EWX_FORCE);
            else
                DoExitWin(EWX_LOGOFF | EWX_FORCEIFHUNG);
        }
        #endregion


        #region  系统音量操作


        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        /// <summary>
        /// 系统增加
        /// </summary>
        /// <param name="volume"></param>
        public static void VolumeUP(int volume = 1)
        {
            new Thread(() => {
                for (int i = 0; i < volume; i++)
                {
                    keybd_event((byte)System.Windows.Forms.Keys.VolumeUp, 0, 0, 0);
                    Thread.Sleep(50);
                }
            }).Start();
        }

        /// <summary>
        /// 系统音量减小
        /// </summary>
        /// <param name="volume"></param>
        public static void VolumeDown(int volume = 1)
        {
            new Thread(() => {
                for (int i = 0; i < volume; i++)
                {
                    keybd_event((byte)System.Windows.Forms.Keys.VolumeDown, 0, 0, 0);//+
                    Thread.Sleep(50);
                }
            }).Start();

        }
        /// <summary>
        /// 系统静音或者从静音状态恢复
        /// </summary>
        public static void VolumeMute()
        {
            keybd_event((byte)System.Windows.Forms.Keys.VolumeMute, 0, 0, 0);//静音
        }
        #endregion


        /// <summary>
        /// 写入注册表，设置开机启动
        /// </summary>
        /// <param name="filepath">需要开机启动的文件</param>
        /// <param name="isAutoRun">是否开机启动</param>
        public static void SetAutoRun(string filepath, bool isAutoRun = true)
        {
            try
            {
                RegistryKey reg = null;
                reg = Reg.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Reg.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (!System.IO.File.Exists(filepath)) return;
                String name = Path.GetFileNameWithoutExtension(filepath);

                if (isAutoRun) { if (null != reg.GetValue(name)) return; reg.SetValue(name, filepath); System.Windows.Forms.MessageBox.Show("设置自启动成功"); }
                else { reg.DeleteValue(name); System.Windows.Forms.MessageBox.Show("删除成功"); }

                reg.Flush();
                reg = null;
            }
            catch { System.Windows.Forms.MessageBox.Show("删除成功"); return; }
        }
    }
}
