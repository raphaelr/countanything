using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CountAnything.Hotkeys {
    static class HotkeyApi {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static void Register(IWin32Window owner, int id, Hotkey hotkey)
        {
            if(hotkey == null) return;

            uint modifiers = 0;
            if(hotkey.Alt) modifiers |= 0x0001;
            if(hotkey.Control) modifiers |= 0x0002;
            if(hotkey.Shift) modifiers |= 0x0004;
            
            RegisterHotKey(owner.Handle, id, modifiers, (uint) hotkey.Keycode);
        }

        public static void Unregister(IWin32Window owner, int id)
        {
            UnregisterHotKey(owner.Handle, id);
        }
    }
}
