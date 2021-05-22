using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows;

namespace Desktop_Arranger.Helper
{
    class WindowsHelper
    {
        static public void setWindowsBottom(Window window)
        {
            // Set to the bottom
            IntPtr hWnd = new WindowInteropHelper(window).Handle;
            SetWindowPos(hWnd, new IntPtr(1), 0, 0, 0, 0, 0x0001 | 0x0002 | 0x0010);
        }

        [DllImport("user32.dll")]
        static private extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int Width, int Height, uint flags);

    }
}
