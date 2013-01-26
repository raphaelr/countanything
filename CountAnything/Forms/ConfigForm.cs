using System;
using System.Windows.Forms;
using CountAnything.Properties;

namespace CountAnything.Forms {
    public partial class ConfigForm : Form {
        private readonly CounterConfig _config;

        public ConfigForm()
        {
            InitializeComponent();
            
            _config = Settings.Default.Config ?? CounterConfig.Default;
            numMax.Value = _config.Max;
            hotkeyIncrement.Hotkey = _config.HotkeyIncrement;
            colorDone.SelectedColor = _config.ColorDone;
            colorNotDone.SelectedColor = _config.ColorNotDone;
            colorBackground.SelectedColor = _config.ColorBackground;
            fontInput.SelectedFont = _config.Font;
            textFormat.Text = _config.Format;
            numDoubleTapPrevention.Value = (decimal) _config.DoubleTapPrevention.TotalMilliseconds;
        }

        private void ButtonStartOnClick(object sender, EventArgs e)
        {
            UpdateConfig();
            var counter = new CounterForm(_config);
            Hide();
            counter.ShowDialog();
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            UpdateConfig();

            Settings.Default.Config = _config;
            Settings.Default.Save();
        }

        private void UpdateConfig()
        {
            _config.Max = (int) numMax.Value;
            _config.HotkeyIncrement = hotkeyIncrement.Hotkey;
            _config.ColorDone = colorDone.SelectedColor;
            _config.ColorNotDone = colorNotDone.SelectedColor;
            _config.ColorBackground = colorBackground.SelectedColor;
            _config.Font = fontInput.SelectedFont;
            _config.Format = textFormat.Text;
            _config.DoubleTapPrevention =
                TimeSpan.FromMilliseconds((double) numDoubleTapPrevention.Value);
        }
    }
}
