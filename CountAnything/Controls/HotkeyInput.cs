using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CountAnything.Controls {
    [DesignerCategory("")]
    public class HotkeyInput : UserControl {
        private readonly TextBox _textBox;
        private readonly Button _clearButton;

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

        public HotkeyInput()
        {
            var tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;

            _textBox = new TextBox();
            _textBox.KeyDown += TextBoxOnKeyDown;
            _textBox.Dock = DockStyle.Fill;
            _textBox.Margin = new Padding(0);

            _clearButton = new Button();
            _clearButton.Text = "Clear";
            _clearButton.Click += ButtonClearOnClick;
            _clearButton.Margin = new Padding(0);
            _clearButton.Height = _textBox.Height;

            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            
            tableLayout.Controls.Add(_textBox, 0, 0);
            tableLayout.Controls.Add(_clearButton, 1, 0);
            tableLayout.Dock = DockStyle.Fill;

            Controls.Add(tableLayout);
            HotkeyUpdated();
        }

        private void TextBoxOnKeyDown(object sender, KeyEventArgs e)
        {
            Hotkey = Hotkey.FromEventArgs(e);
            e.SuppressKeyPress = true;
        }

        private void ButtonClearOnClick(object sender, EventArgs e)
        {
            Hotkey = null;
        }

        private void HotkeyUpdated()
        {
            _textBox.Text = Hotkey == null ? "None" : Hotkey.ToString();
        }
    }
}
