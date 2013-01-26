using System;
using System.Windows.Forms;

namespace CountAnything.Forms {
    public partial class SetValueDialog : Form {
        public int Value { get; private set; }

        public SetValueDialog(int oldValue)
        {
            InitializeComponent();
            numValue.Value = Value = oldValue;
            numValue.Select(0, numValue.Text.Length);
        }

        private void ButtonOkOnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Value = (int) numValue.Value;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if(DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}
