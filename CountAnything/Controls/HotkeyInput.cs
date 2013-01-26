using System.ComponentModel;
using System.Windows.Forms;

namespace CountAnything.Controls {
    [DesignerCategory("")]
    public class HotkeyInput : TextBox {
        private Hotkey _hotkey;
        public Hotkey Hotkey
        {
            get { return _hotkey; }
            set
            {
                if(_hotkey != value) {
                    _hotkey = value;
                    HotkeyUpdated();
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            Hotkey = Hotkey.FromEventArgs(e);
            e.SuppressKeyPress = true;
        }

        private void HotkeyUpdated()
        {
            Text = Hotkey.ToString();
        }
    }
}
