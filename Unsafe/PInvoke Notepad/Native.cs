// credit: http://msdn.microsoft.com/en-us/magazine/cc164123.aspx

namespace PInvoke_Notepad
{
    using System;
    using System.Runtime.InteropServices;
    using System.ComponentModel;
    using System.Text;

    public static class Native
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);


        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }



    }
    public enum SpecialWindowHandles
    {
        HWND_TOP = 0,
        HWND_BOTTOM = 1,
        HWND_TOPMOST = -1,
        HWND_NOTOPMOST = -2
    }

    [Flags]
    public enum SetWindowPosFlags : uint
    {
        SWP_ASYNCWINDOWPOS = 0x4000,

        SWP_DEFERERASE = 0x2000,

        SWP_DRAWFRAME = 0x0020,

        SWP_FRAMECHANGED = 0x0020,

        SWP_HIDEWINDOW = 0x0080,

        SWP_NOACTIVATE = 0x0010,

        SWP_NOCOPYBITS = 0x0100,

        SWP_NOMOVE = 0x0002,

        SWP_NOOWNERZORDER = 0x0200,

        SWP_NOREDRAW = 0x0008,

        SWP_NOREPOSITION = 0x0200,

        SWP_NOSENDCHANGING = 0x0400,

        SWP_NOSIZE = 0x0001,

        SWP_NOZORDER = 0x0004,

        SWP_SHOWWINDOW = 0x0040,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
}


