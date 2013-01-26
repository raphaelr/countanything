using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything.Forms {
    public partial class CounterForm : Form {
        private const int OuterPadding = 5;
        private const int IncrementId = 1;

        private readonly CounterConfig _config;
        private readonly Font _font;
        private int _remaining;

        public CounterForm(CounterConfig config)
        {
            _config = config;
            _font = _config.Font.CreateFont();
            InitializeComponent();
            WindowDragHelper.EnableDrag(this, textCounter);
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            HotkeyApi.Register(this, IncrementId, _config.Increment);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            HotkeyApi.Unregister(this, IncrementId);
        }

        protected override void WndProc(ref Message m)
        {
            switch(m.Msg) {
            case 0x0312:
                if((int)m.WParam == IncrementId) {
                    Increment();
                }
                return;
            }

            base.WndProc(ref m);
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
