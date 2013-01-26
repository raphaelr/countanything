using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything {
    class FontInput : TextBox {
        private FontDescription _selectedFont;
        
        public FontDescription SelectedFont
        {
            get { return _selectedFont; }
            set
            {
                if(_selectedFont == value) return;
                _selectedFont = value;
                SelectedFontOnUpdate();
            }
        }

        public FontInput()
        {
            ReadOnly = true;
            SelectedFont = FontDescription.FromFont(SystemFonts.DefaultFont);
            SelectedFontOnUpdate();
        }

        protected override void OnClick(EventArgs e)
        {
            var fod = new FontDialog();
            var result = fod.ShowDialog();
            if(result == DialogResult.OK) {
                SelectedFont = FontDescription.FromFont(fod.Font);
            }
        }

        private void SelectedFontOnUpdate()
        {
            Text = SelectedFont == null ? "(null)" : SelectedFont.ToString();
        }
    }
}
