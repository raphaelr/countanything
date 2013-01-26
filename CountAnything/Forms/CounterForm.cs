using System;
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
                if(_value != value) {
                    _value = value;
                    ValueUpdated();
                }
            }
        }

        private readonly CounterConfig _config;
        private readonly Font _font;
        private readonly HotkeyManager _hotkeyManager;
        private int _value;

        public CounterForm(CounterConfig config)
        {
            _config = config;
            _font = _config.Font.CreateFont();
            _hotkeyManager = new HotkeyManager();
            _hotkeyManager.DoubleTapPrevention = config.DoubleTapPrevention;

            InitializeComponent();
            WindowDragHelper.EnableDrag(this, textCounter);
            _hotkeyManager.Map(config.HotkeyIncrement, () => { Value++; });
        }

        protected override void OnLoad(EventArgs e)
        {
            TopMost = stayonTopToolStripMenuItem.Checked = _config.StayOnTop;

            var graphics = CreateGraphics();
            var maxDimension = graphics.MeasureString(Format(_config.Max), _font, int.MaxValue);
            ClientSize = new Size(OuterPadding + (int) maxDimension.Width, OuterPadding + (int) maxDimension.Height);

            BackColor = _config.ColorBackground;
            textCounter.Font = _font;
            ValueUpdated();
        }

        protected override void OnResize(EventArgs e)
        {
            CenterText();
        }

        private void ValueUpdated()
        {
            textCounter.ForeColor = Value >= _config.Max ? _config.ColorDone : _config.ColorNotDone;
            textCounter.Text = Format(Value);
            CenterText();
        }

        private void CenterText()
        {
            textCounter.Left = (ClientSize.Width - textCounter.Width)/2;
            textCounter.Top = (ClientSize.Height - textCounter.Height)/2;
        }

        private string Format(int value)
        {
            return string.Format(_config.Format, value, _config.Max, _config.Max - value,
                                 (float) value/(float) _config.Max);
        }

        private void MenuIncrementOnClick(object sender, EventArgs e)
        {
            Value++;
        }

        private void MenuDecrementOnClick(object sender, EventArgs e)
        {
            if(Value <= 0) return;
            Value--;
        }

        private void MenuResetOnClick(object sender, EventArgs e)
        {
            Value = 0;
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
            _config.StayOnTop = TopMost = stayonTopToolStripMenuItem.Checked;
        }

        private void MenuAboutOnClick(object sender, EventArgs e)
        {
            var versionAttribute = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
                                                                typeof(
                                                                    AssemblyFileVersionAttribute
                                                                    ), false);

            var version = ((AssemblyFileVersionAttribute) versionAttribute).Version;

            MessageBox.Show(string.Format("CountAnything v{0}\n" +
                                          "By tape1 // twitch.tv/tape1\n\n" +
                                          "Get the latest and greatest version from\n" +
                                          "http://bombch.us/9o", version), "About CountAnything");
        }

        private void MenuExitOnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
