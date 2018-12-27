using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PInvoke_Notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = Process.Start("notepad.exe");
            try
            {
                Console.WriteLine("press any key to exit");
                p.WaitForInputIdle();

                IntPtr handle = p.MainWindowHandle;
                Native.SetWindowPos(handle, new IntPtr((int)SpecialWindowHandles.HWND_TOP),
                                    500,
                                    60, 450, 450, SetWindowPosFlags.SWP_SHOWWINDOW);

                Native.SetForegroundWindow(handle);
                Follow(handle);
            }
            finally
            {
                p.Kill();
                p.Dispose();
            }
        }

        private static void Follow(IntPtr handle)
        {
            RECT rect = new RECT();
            POINT pt = new POINT();
            while (true)
            {
                Native.GetWindowRect(handle, ref rect);
                Native.GetCursorPos(out pt);
                int moveX, moveY;

                moveX = (pt.X - rect.left) / 30;
                moveY = (pt.Y - rect.top) / 30;

                Native.SetWindowPos(handle, new IntPtr((int)SpecialWindowHandles.HWND_TOP),
                                    rect.left + moveX,
                                    rect.top + moveY,
                                    rect.right - rect.left,
                                    rect.bottom - rect.top, SetWindowPosFlags.SWP_SHOWWINDOW);

                Thread.Sleep(10);
                if (Console.KeyAvailable)
                    break;
            }
        }
    }
}
