using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything {
    public partial class ColorInput : UserControl {
        private Color _value;
        public Color Value
        {
            get { return _value; }
            set
            {
                if(_value != value) {
                    _value = value;
                    ValueUpdated();
                }
            }
        }

        public ColorInput()
        {
            InitializeComponent();
            _value = Color.Black;
        }

        protected override void OnClick(EventArgs e)
        {
            var cld = new ColorDialog();
            var result = cld.ShowDialog();
            if(result == DialogResult.OK) {
                Value = cld.Color;
            }
        }

        private void ValueUpdated()
        {
            BackColor = Value;
        }
    }
}
