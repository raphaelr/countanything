using System;
using System.Drawing;
using System.Windows.Forms;
using CountAnything.Hotkeys;

namespace CountAnything.Forms {
    public partial class CounterForm : Form {
        private const int OuterPadding = 5;

        private readonly CounterConfig _config;
        private readonly Font _font;
        private readonly HotkeyManager _hotkeyManager;
        private int _remaining;

        public CounterForm(CounterConfig config)
        {
            _config = config;
            _font = _config.Font.CreateFont();
            _hotkeyManager = new HotkeyManager();

            InitializeComponent();
            WindowDragHelper.EnableDrag(this, textCounter);
            _hotkeyManager.Map(config.Increment, Increment);
        }

        protected override void OnLoad(EventArgs e)
        {
            var graphics = CreateGraphics();
            var maxDimension =
                graphics.MeasureString(string.Format(_config.Format, _config.Max, _config.Max),
                                       _font, int.MaxValue);
            ClientSize = new Size(OuterPadding + (int) maxDimension.Width, OuterPadding + (int) maxDimension.Height);

            _remaining = _config.Max;
            BackColor = _config.Background;
            textCounter.Font = _font;
            UpdateCounter();
        }

        protected override void OnResize(EventArgs e)
        {
            CenterText();
        }

        private void Increment()
        {
            _remaining--;
            UpdateCounter();
        }

        private void UpdateCounter()
        {
            textCounter.ForeColor = _remaining <= 0 ? _config.Done : _config.NotDone;
            textCounter.Text = string.Format(_config.Format, _config.Max - _remaining, _config.Max);
            CenterText();
        }

        private void CenterText()
        {
            textCounter.Left = (ClientSize.Width - textCounter.Width)/2;
            textCounter.Top = (ClientSize.Height - textCounter.Height)/2;
        }
    }
}
