using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CountAnything.Forms {
    static class WindowDragHelper {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture(IntPtr hwnd);

        public static void EnableDrag(IWin32Window owner, Control control)
        {
            control.MouseDown += delegate(object sender, MouseEventArgs args) {
                ReleaseCapture(((Control) sender).Handle);
                SendMessage(owner.Handle, 0x0112, (IntPtr) 0xf012, IntPtr.Zero);
            };
        }
    }
}
