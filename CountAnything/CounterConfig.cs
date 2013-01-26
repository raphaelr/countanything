using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CountAnything.Annotations;

namespace CountAnything {
    [Serializable]
    public class CounterConfig : INotifyPropertyChanged {
        private int _max;
        private string _format;
        private TimeSpan _doubleTapPrevention;
        private Color _colorNotDone;
        private Color _colorDone;
        private Color _colorBackground;
        private FontDescription _font;
        private bool _stayOnTop;
        private Hotkey _hotkeyIncrement;
        private Hotkey _hotkeyDecrement;
        private Hotkey _hotkeyReset;

        public int Max
        {
            get { return _max; }
            set
            {
                if(value == _max) return;
                _max = value;
                OnPropertyChanged("Max");
            }
        }

        public string Format
        {
            get { return _format; }
            set
            {
                if(value == _format) return;
                _format = value;
                OnPropertyChanged("Format");
            }
        }

        public TimeSpan DoubleTapPrevention
        {
            get { return _doubleTapPrevention; }
            set
            {
                if(value.Equals(_doubleTapPrevention)) return;
                _doubleTapPrevention = value;
                OnPropertyChanged("DoubleTapPrevention");
            }
        }

        public Color ColorNotDone
        {
            get { return _colorNotDone; }
            set
            {
                if(value.Equals(_colorNotDone)) return;
                _colorNotDone = value;
                OnPropertyChanged("ColorNotDone");
            }
        }

        public Color ColorDone
        {
            get { return _colorDone; }
            set
            {
                if(value.Equals(_colorDone)) return;
                _colorDone = value;
                OnPropertyChanged("ColorDone");
            }
        }

        public Color ColorBackground
        {
            get { return _colorBackground; }
            set
            {
                if(value.Equals(_colorBackground)) return;
                _colorBackground = value;
                OnPropertyChanged("ColorBackground");
            }
        }

        public FontDescription Font
        {
            get { return _font; }
            set
            {
                if(Equals(value, _font)) return;
                _font = value;
                OnPropertyChanged("Font");
            }
        }

        public bool StayOnTop
        {
            get { return _stayOnTop; }
            set
            {
                if(value.Equals(_stayOnTop)) return;
                _stayOnTop = value;
                OnPropertyChanged("StayOnTop");
            }
        }

        public Hotkey HotkeyIncrement
        {
            get { return _hotkeyIncrement; }
            set
            {
                if(Equals(value, _hotkeyIncrement)) return;
                _hotkeyIncrement = value;
                OnPropertyChanged("HotkeyIncrement");
            }
        }

        public Hotkey HotkeyDecrement
        {
            get { return _hotkeyDecrement; }
            set
            {
                if(Equals(value, _hotkeyDecrement)) return;
                _hotkeyDecrement = value;
                OnPropertyChanged("HotkeyDecrement");
            }
        }

        public Hotkey HotkeyReset
        {
            get { return _hotkeyReset; }
            set
            {
                if(Equals(value, _hotkeyReset)) return;
                _hotkeyReset = value;
                OnPropertyChanged("HotkeyReset");
            }
        }

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
                    StayOnTop = true,

                    HotkeyIncrement = new Hotkey {
                        Alt = false,
                        Control = false,
                        Shift = false,
                        KeyCode = Keys.Insert
                    },
                };
                return self;
            }
        }

        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
