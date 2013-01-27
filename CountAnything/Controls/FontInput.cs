using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything.Controls {
    [DesignerCategory("")]
    class FontInput : TextBox {
        public event EventHandler<EventArgs> SelectedFontChanged;

        private FontDescription _selectedFont;
        
        public FontDescription SelectedFont
        {
            get { return _selectedFont; }
            set
            {
                if(_selectedFont == value) return;
                _selectedFont = value;
                OnSelectedFontChanged();
            }
        }

        public FontInput()
        {
            ReadOnly = true;
            SelectedFont = FontDescription.FromFont(SystemFonts.DefaultFont);
        }

        protected override void OnClick(EventArgs e)
        {
            var fod = new FontDialog();
            fod.Font = SelectedFont.CreateFont();
            if(fod.ShowDialog() == DialogResult.OK) {
                SelectedFont = FontDescription.FromFont(fod.Font);
            }
        }

        protected virtual void OnSelectedFontChanged()
        {
            Text = SelectedFont == null ? "(null)" : SelectedFont.ToString();
            var handler = SelectedFontChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}
