using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything {
    [DesignerCategory("")]
    class ColorInput : UserControl {
        private Color _selectedColor;
        public Color SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                if(_selectedColor != value) {
                    _selectedColor = value;
                    SelectedColorOnUpdate();
                }
            }
        }

        public ColorInput()
        {
            SelectedColor = Color.Black;
        }

        protected override void OnClick(EventArgs e)
        {
            var cld = new ColorDialog();
            var result = cld.ShowDialog();
            if(result == DialogResult.OK) {
                SelectedColor = cld.Color;
            }
        }

        private void SelectedColorOnUpdate()
        {
            BackColor = SelectedColor;
        }
    }
}
