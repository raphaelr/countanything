using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything.Controls {
    [DesignerCategory("")]
    class ColorInput : UserControl {
        public event EventHandler<EventArgs> SelectedColorChanged;

        private Color _selectedColor;
        public Color SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                if(_selectedColor != value) {
                    _selectedColor = value;
                    OnSelectedColorChanged();
                }
            }
        }

        public ColorInput()
        {
            SelectedColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void OnClick(EventArgs e)
        {
            var cld = new ColorDialog();
            var result = cld.ShowDialog();
            if(result == DialogResult.OK) {
                SelectedColor = cld.Color;
            }
        }

        protected virtual void OnSelectedColorChanged()
        {
            BackColor = SelectedColor;
            var handler = SelectedColorChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}
