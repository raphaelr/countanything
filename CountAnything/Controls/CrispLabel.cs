using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CountAnything.Controls {
    [DesignerCategory("")]
    class CrispLabel : Label {
        private SolidBrush _foreground;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            e.Graphics.DrawString(Text, Font, _foreground, 0, 0);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            _foreground = new SolidBrush(ForeColor);
        }
    }
}
