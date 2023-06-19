using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SendKeyToWindow
{
    class _api
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }


        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static IntPtr GetActiveWindowHandle()
        {
            return GetForegroundWindow();
        }

        public static bool SetActiveWindow(IntPtr hWnd)
        {
            SetForegroundWindow(hWnd);
            return true;
        }

        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
                return Buff.ToString();

            return null;
        }

        public static void SendKeys(IntPtr windowHandle, string key)
        {
            if (SetForegroundWindow(windowHandle))
                System.Windows.Forms.SendKeys.Send(key);
        }

        public static void SendKeys(IntPtr windowHandle, bool ctrlActive, bool altActive, string key)
        {
            if (ctrlActive)
                SendKeys(windowHandle, "^{" + key.ToLower() + "}");
            else if (altActive)
                SendKeys(windowHandle, "%{" + key.ToLower() + "}");
            else
                SendKeys(windowHandle, "{" + key + "}");
        }
    }
}
