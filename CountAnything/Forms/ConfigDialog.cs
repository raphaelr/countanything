using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CountAnything.Forms {
    public partial class ConfigDialog : Form {
        private readonly CounterConfig _config;

        public ConfigDialog(CounterConfig config)
        {
            _config = config;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            numMax.Value = _config.Max;
            colorNotDone.SelectedColor = _config.ColorNotDone;
            colorDone.SelectedColor = _config.ColorDone;
            colorBackground.SelectedColor = _config.ColorBackground;
            fontInput.SelectedFont = _config.Font;
            textFormat.Text = _config.Format;
            numDoubleTapPrevention.Value = (decimal) _config.DoubleTapPrevention.TotalMilliseconds;
            hotkeyIncrement.Hotkey = _config.HotkeyIncrement;
            hotkeyDecrement.Hotkey = _config.HotkeyDecrement;
            hotkeyReset.Hotkey = _config.HotkeyReset;
        }

        private void ButtonSaveOnClick(object sender, EventArgs e)
        {
            _config.DoubleTapPrevention = TimeSpan.FromMilliseconds((double) numDoubleTapPrevention.Value);
            _config.HotkeyIncrement = hotkeyIncrement.Hotkey;
            _config.HotkeyDecrement = hotkeyDecrement.Hotkey;
            _config.HotkeyReset = hotkeyReset.Hotkey;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancelOnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NumMaxOnChanged(object sender, EventArgs e)
        {
            _config.Max = (int) numMax.Value;
        }

        private void ColorNotDoneOnChanged(object sender, EventArgs e)
        {
            _config.ColorNotDone = colorNotDone.SelectedColor;
        }

        private void ColorDoneOnChanged(object sender, EventArgs e)
        {
            _config.ColorDone = colorDone.SelectedColor;
        }

        private void ColorBackgroundOnChanged(object sender, EventArgs e)
        {
            _config.ColorBackground = colorBackground.SelectedColor;
        }

        private void FontInputOnChanged(object sender, EventArgs e)
        {
            _config.Font = fontInput.SelectedFont;
        }

        private void TextFormatOnChanged(object sender, EventArgs e)
        {
            _config.Format = textFormat.Text;
        }

        private void LinkFormatHelpOnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string text = "Indices for the format string:\n\n" +
                                "0: Current value of the counter\n" +
                                "1: Maximum value of the counter\n" +
                                "2: Maximum - Current\n" +
                                "3: Current / Maximum\n\n" +
                                "Note: for #3, you can use the percentage format specifier, like this: {3:p}";

            MessageBox.Show(text, "Format string indices", MessageBoxButtons.OK);
        }

        private void LinkGeneralFormatHelpOnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "http://msdn.microsoft.com/en-us/library/txafckwd(v=vs.80).aspx";
            Process.Start(url);
        }
    }
}
