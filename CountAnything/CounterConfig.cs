using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything {
    [Serializable]
    public class CounterConfig {
        public int Max { get; set; }
        public string Format { get; set; }
        public TimeSpan DoubleTapPrevention { get; set; }

        public Color ColorNotDone { get; set; }
        public Color ColorDone { get; set; }
        public Color ColorBackground { get; set; }
        public FontDescription Font { get; set; }

        public Hotkey HotkeyIncrement { get; set; }

        public static CounterConfig Default
        {
            get
            {
                var self = new CounterConfig {
                    Max = 60,
                    Format = "{0}/{1}",
                    DoubleTapPrevention = TimeSpan.FromMilliseconds(500),

                    ColorNotDone = Color.Orange,
                    ColorDone = Color.LimeGreen,
                    ColorBackground = Color.Black,
                    Font = new FontDescription("Arial", 40, FontStyle.Bold),

                    HotkeyIncrement = new Hotkey {
                        Alt = false,
                        Control = false,
                        Shift = false,
                        Keycode = (int)Keys.Insert
                    },
                };
                return self;
            }
        }
    }
}
