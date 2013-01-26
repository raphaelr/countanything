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

        private readonly CounterConfig _config;
        private readonly HotkeyManager _hotkeyManager;
        private HotkeyHandle _hotkeyIncrement, _hotkeyDecrement, _hotkeyReset;
        private int _value;

        public CounterForm()
        {
            _config = Program.LoadConfig();
            _config.PropertyChanged += ConfigOnPropertyChanged;
            _hotkeyManager = new HotkeyManager();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            WindowDragHelper.EnableDrag(this, textCounter);
            ConfigInitialLoad();
            ValueUpdated();
            
            stayonTopToolStripMenuItem.Checked = _config.StayOnTop;
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
        }

        private void ConfigMaxUpdated()
        {
            ValueUpdated();
        }

        private void ConfigHotkeysUpdated()
        {
            if(_hotkeyIncrement != null) _hotkeyIncrement.Unmap();
            if(_hotkeyDecrement != null) _hotkeyDecrement.Unmap();
            if(_hotkeyReset != null) _hotkeyReset.Unmap();

            _hotkeyIncrement = _hotkeyManager.Map(_config.HotkeyIncrement, Increment);
            _hotkeyDecrement = _hotkeyManager.Map(_config.HotkeyDecrement, Decrement);
            _hotkeyReset = _hotkeyManager.Map(_config.HotkeyReset, Reset);
        }

        private void ConfigStayOnTopUpdated()
        {
            TopMost = _config.StayOnTop;
        }

        private void ConfigColorsUpdated()
        {
            BackColor = _config.ColorBackground;
            UpdateTextColor();
        }

        private void ConfigFontUpdated()
        {
            textCounter.Font = _config.Font.CreateFont();
            UpdateSize();
        }

        private void UpdateTextColor()
        {
            textCounter.ForeColor = Value >= _config.Max ? _config.ColorDone : _config.ColorNotDone;
        }

        private void UpdateSize()
        {
            var graphics = CreateGraphics();
            var maxDimension = graphics.MeasureString(Format(_config.Max), textCounter.Font,
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
            return string.Format(_config.Format, value, _config.Max, _config.Max - value,
                                 (float)value / (float)_config.Max);
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
            Program.SaveConfig(_config);
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
            var svf = new SetValueForm(Value);
            if(svf.ShowDialog() == DialogResult.OK) {
                Value = svf.Value;
            }
        }

        private void MenuStayOnTopOnCheckedChanged(object sender, EventArgs e)
        {
            _config.StayOnTop = stayonTopToolStripMenuItem.Checked;
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
