using System;
using System.Windows.Forms;

namespace CountAnything {
    class FontInput : TextBox {
        public FontInput()
        {
            ReadOnly = true;
            FontUpdated();
        }

        protected override void OnClick(EventArgs e)
        {
            var fod = new FontDialog();
            var result = fod.ShowDialog();
            if(result == DialogResult.OK) {
                Font = fod.Font;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            FontUpdated();
            base.OnFontChanged(e);
        }

        private void FontUpdated()
        {
            Text = string.Format("{0} {1} {2}", Font.Name, Font.Size, Font.Style);
        }
    }
}
