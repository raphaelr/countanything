using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountAnything {
    [Serializable]
    public class CounterConfig {
        public int Max { get; set; }
        public Hotkey Increment { get; set; }
        public Color NotDone { get; set; }
        public Color Done { get; set; }
        public Color Background { get; set; }
        public Font Font { get; set; }
        public string Format { get; set; }

        public static CounterConfig Default
        {
            get
            {
                var self = new CounterConfig {
                    Max = 60,
                    Increment = new Hotkey {
                        Alt = false,
                        Control = false,
                        Shift = false,
                        Keycode = (int) Keys.Insert
                    },

                    NotDone = Color.OrangeRed,
                    Done = Color.Green,
                    Background = SystemColors.Control,
                    Font = new Font("Arial", 40, FontStyle.Bold),
                    Format = "{0}/{1}",
                };
                return self;
            }
        }
    }
}
