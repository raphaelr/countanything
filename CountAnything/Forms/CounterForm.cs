using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using CountAnything.Hotkeys;

namespace CountAnything.Forms {
    public partial class CounterForm : Form {
        private const int OuterPadding = 5;

        private int Value
        {
            get { return _value; }
            set
            {
                if(_value == value) return;
                _value = value;
                ValueUpdated();
            }
        }

        private CounterConfig Config
        {
            get { return _config; }
            set
            {
                if(_config == value) return;
                if(_config != null) {
                    _config.PropertyChanged -= ConfigOnPropertyChanged;
                    UnmapHotkeys();
                }

                _config = value;
                _config.PropertyChanged += ConfigOnPropertyChanged;
                ConfigInitialLoad();
            }
        }

        private readonly HotkeyManager _hotkeyManager;
        private HotkeyHandle _hotkeyIncrement, _hotkeyDecrement, _hotkeyReset;
        private int _value;
        private CounterConfig _config;

        public CounterForm()
        {
            _hotkeyManager = new HotkeyManager();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            WindowDragHelper.EnableDrag(this, textCounter);
            Config = Program.LoadConfig();
            ValueUpdated();
            
            stayonTopToolStripMenuItem.Checked = Config.StayOnTop;
        }

        private void ConfigOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName.StartsWith("Color")) {
                ConfigColorsUpdated();
            } else if(e.PropertyName.StartsWith("Hotkey")) {
                ConfigHotkeysUpdated();
            } else if(e.PropertyName == "Font") {
                ConfigFontUpdated();
            } else if(e.PropertyName == "StayOnTop") {
                ConfigStayOnTopUpdated();
            } else if(e.PropertyName == "Max") {
                ConfigMaxUpdated();
            } else if(e.PropertyName == "Format") {
                ConfigFormatUpdated();
            } else if(e.PropertyName == "DoubleTapPrevention") {
                ConfigDoubleTapPreventionUpdated();
            }
        }

        private void ValueUpdated()
        {
            textCounter.Text = Format(Value);
            CenterText();
            UpdateTextColor();
        }

        private void ConfigInitialLoad()
        {
            ConfigHotkeysUpdated();
            ConfigStayOnTopUpdated();
            ConfigColorsUpdated();
            ConfigFontUpdated();
            ConfigDoubleTapPreventionUpdated();
        }

        private void ConfigMaxUpdated()
        {
            ValueUpdated();
        }

        private void ConfigHotkeysUpdated()
        {
            UnmapHotkeys();

            _hotkeyIncrement = _hotkeyManager.Map(Config.HotkeyIncrement, Increment);
            _hotkeyDecrement = _hotkeyManager.Map(Config.HotkeyDecrement, Decrement);
            _hotkeyReset = _hotkeyManager.Map(Config.HotkeyReset, Reset);
        }

        private void ConfigStayOnTopUpdated()
        {
            TopMost = Config.StayOnTop;
        }

        private void ConfigColorsUpdated()
        {
            BackColor = Config.ColorBackground;
            UpdateTextColor();
        }

        private void ConfigFontUpdated()
        {
            textCounter.Font = Config.Font.CreateFont();
            UpdateSize();
        }

        private void ConfigFormatUpdated()
        {
            try {
                UpdateSize();
                ValueUpdated();
            } catch(FormatException) { }
        }

        private void ConfigDoubleTapPreventionUpdated()
        {
            _hotkeyManager.DoubleTapPrevention = _config.DoubleTapPrevention;
        }

        private void UpdateTextColor()
        {
            textCounter.ForeColor = Value >= Config.Max ? Config.ColorDone : Config.ColorNotDone;
        }

        private void UpdateSize()
        {
            var graphics = CreateGraphics();
            var maxDimension = graphics.MeasureString(Format(Config.Max), textCounter.Font,
                                                      int.MaxValue);
            ClientSize = new Size(OuterPadding + (int) maxDimension.Width,
                                  OuterPadding + (int) maxDimension.Height);
        }

        private void CenterText()
        {
            textCounter.Left = (ClientSize.Width - textCounter.Width) / 2;
            textCounter.Top = (ClientSize.Height - textCounter.Height) / 2;
        }

        private string Format(int value)
        {
            return string.Format(Config.Format, value, Config.Max, Config.Max - value,
                                 (float)value / (float)Config.Max);
        }
        
        private void UnmapHotkeys()
        {
            if(_hotkeyIncrement != null) _hotkeyIncrement.Unmap();
            if(_hotkeyDecrement != null) _hotkeyDecrement.Unmap();
            if(_hotkeyReset != null) _hotkeyReset.Unmap();
        }

        private void Increment()
        {
            Value++;
        }

        private void Decrement()
        {
            if(Value <= 0) return;
            Value--;
        }

        private void Reset()
        {
            Value = 0;
        }

        protected override void OnResize(EventArgs e)
        {
            CenterText();
        }

        protected override void OnClosed(EventArgs e)
        {
            Program.SaveConfig(Config);
        }

        #region Context Menu Handlers

        private void MenuIncrementOnClick(object sender, EventArgs e)
        {
            Increment();
        }

        private void MenuDecrementOnClick(object sender, EventArgs e)
        {
            Decrement();
        }

        private void MenuResetOnClick(object sender, EventArgs e)
        {
            Reset();
        }

        private void MenuSetValueOnClick(object sender, EventArgs e)
        {
            var svd = new SetValueDialog(Value);
            if(svd.ShowDialog() == DialogResult.OK) {
                Value = svd.Value;
            }
        }

        private void MenuConfigureOnClick(object sender, EventArgs e)
        {
            var tempConfig = CloneHelper.Clone(Config);
            var originalConfig = Config;
            Config = tempConfig;

            var cfg = new ConfigDialog(tempConfig);
            cfg.TopMost = TopMost;
            if(cfg.ShowDialog() != DialogResult.OK) {
                Config = originalConfig;
            }
        }

        private void MenuStayOnTopOnCheckedChanged(object sender, EventArgs e)
        {
            Config.StayOnTop = stayonTopToolStripMenuItem.Checked;
        }

        private void MenuAboutOnClick(object sender, EventArgs e)
        {
            var versionAttribute = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
                                                                typeof(
                                                                    AssemblyFileVersionAttribute
                                                                    ), false);

            var version = ((AssemblyFileVersionAttribute) versionAttribute).Version;

            MessageBox.Show(string.Format("CountAnything v{0}\n" +
                                          "By tape1  //  twitch.tv/tape1\n\n" +
                                          "Get the latest and greatest version from\n" +
                                          "http://bombch.us/9o", version), "About CountAnything");
        }

        private void MenuExitOnClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
