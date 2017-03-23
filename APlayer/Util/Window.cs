namespace LLSDK.WinAPI
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms; 
    using System.Drawing;
    using System.Collections.Generic;
    using Microsoft.Win32;
    using Reg = Microsoft.Win32.Registry;
    /// <summary>
    /// 系统启动，开关机，音量，鼠标，任务栏隐藏，窗口置顶
    /// </summary>
    public  class Window
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);  
        /// <summary>
        /// 隐藏任务栏
        /// </summary>
        /// <param name="Hide">是否隐藏</param>
        public static void HideTask(bool Hide=true)
        {
            try
            {
                IntPtr trayHwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
                IntPtr hStar = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Button", null);
                if (Hide)
                {
                    ShowWindow(trayHwnd, 0);
                    ShowWindow(hStar, 0);
                }
                else
                {
                    ShowWindow(trayHwnd, 1);
                    ShowWindow(hStar, 1);
                }
            }
            catch { return; }
        }

        [DllImport("User32.dll", EntryPoint = "SetWindowLong", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool SetWindowLong(IntPtr hWnd, int nIndex, int nFlags);
        [DllImport("User32.dll", EntryPoint = "SetLayeredWindowAttributes", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nFlags);
        [DllImport("User32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndWinInsertAfter, int x, int y, int cx, int cy, int nFlags);

        const int WS_EX_TOOLWINDOW = 0x80;
        const int GWL_EXSTYLE = -20;
        const int HWND_TOPMOST = -1;
        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOMOVE = 0x0002;
        /// <summary>
        /// 将 窗口置顶
        /// </summary>
        /// <param name="windowHandle"></param>
        public static void SetWindowAlwaysTop(IntPtr windowHandle)
        {
            SetWindowLong(windowHandle, GWL_EXSTYLE, GetWindowLong(windowHandle, GWL_EXSTYLE) | WS_EX_TOOLWINDOW);
            SetWindowPos(windowHandle, (IntPtr)HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }

        [DllImport("User32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private static extern int FindWindow(String className, String captionName);
        [DllImport("User32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto)]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        #region 鼠标操作
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        private static extern void ShowCursor(int status);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        [Flags]
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000
        }
        /// <summary>
        /// 是否隐藏鼠标
        /// </summary>
        /// <param name="hide">是否隐藏鼠标</param>
        public static void SetCursorStatus(bool hide = true)
        {
            if (hide) ShowCursor(0);
            else ShowCursor(1);
        }

        /// <summary>
        /// 获取鼠标位置
        /// </summary>
        /// <returns></returns>
        public static Point GetCursorPos()
        {
            Point point = new Point();
            GetCursorPos(ref point);
            return point;
        }
        /// <summary>
        /// 设置鼠标的位置
        /// </summary>
        /// <param name="p"></param>
        public static void SetCursorPos(Point p)
        {
            SetCursorPos(p.X, p.Y);
        }
        /// <summary>
        /// 模拟鼠标点击效果
        /// </summary>
        public static void MouseClick()
        {
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }
        /// <summary>
        /// 鼠标左键按下
        /// </summary>
        public static void MouseLeftDown()
        {
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
        }
        /// <summary>
        /// 鼠标左键释放
        /// </summary>
        public static void MouseLeftUp()
        {
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }
        #endregion


        [DllImport("user32.dll")]
        private static extern int MessageBoxTimeout(IntPtr hWnd, string msg, string caption, int type, int DWOD, int time);
        /// <summary>
        /// 定时显示的弹出框
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="Caption"></param>
        /// <param name="time"></param>
        public static void MessageBox(IntPtr hWnd, string msg, string Caption, int time)
        {
            MessageBoxTimeout(hWnd, msg, Caption, 64, 1, time);
        }
        /// <summary>
        /// 默认的弹出框函数
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="Caption"></param>
        public static void MessageBox(IntPtr hWnd, string msg, string Caption)
        {
            MessageBoxTimeout(hWnd, msg, Caption, 64, 1, -1);
        }

        /// <summary>
        /// 带回调的弹出窗口函数
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="handler"></param>
        public static void MessageBox(string msg, Action<System.Windows.Forms.DialogResult> handler)
        {
            var result = System.Windows.Forms.MessageBox.Show(msg, "提示", System.Windows.Forms.MessageBoxButtons.OKCancel);
            handler(result);
        }
    }
}

