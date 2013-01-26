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
            hotkeyIncrement.Hotkey = _config.Increment;
            colorDone.SelectedColor = _config.Done;
            colorNotDone.SelectedColor = _config.NotDone;
            colorBackground.SelectedColor = _config.Background;
            fontInput.SelectedFont = _config.Font;
            textFormat.Text = _config.Format;
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
            _config.Increment = hotkeyIncrement.Hotkey;
            _config.Done = colorDone.SelectedColor;
            _config.NotDone = colorNotDone.SelectedColor;
            _config.Background = colorBackground.SelectedColor;
            _config.Font = fontInput.SelectedFont;
            _config.Format = textFormat.Text;
        }
    }
}
