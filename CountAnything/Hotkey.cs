using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CountAnything {
    [Serializable]
    public class Hotkey {
        public bool Control { get; set; }
        public bool Shift { get; set; }
        public bool Alt { get; set; }
        public int Keycode { get; set; }

        public static Hotkey FromEventArgs(KeyEventArgs e)
        {
            var self = new Hotkey();
            self.Alt = (e.Modifiers & Keys.Alt) != 0;
            self.Control = (e.Modifiers & Keys.Control) != 0;
            self.Shift = (e.Modifiers & Keys.Shift) != 0;
            self.Keycode = e.KeyValue;
            return self;
        }

        public override string ToString()
        {
            var elements = new List<string>();
            if(Control) elements.Add("Ctrl");
            if(Shift) elements.Add("Shift");
            if(Alt) elements.Add("Alt");
            elements.Add(Enum.GetName(typeof(Keys), Keycode));

            return string.Join(" + ", elements.ToArray());
        }

        protected bool Equals(Hotkey other)
        {
            return Control.Equals(other.Control) && Shift.Equals(other.Shift) && Alt.Equals(other.Alt) && Keycode == other.Keycode;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Hotkey) obj);
        }

        public override int GetHashCode()
        {
            unchecked {
                int hashCode = Control.GetHashCode();
                hashCode = (hashCode*397) ^ Shift.GetHashCode();
                hashCode = (hashCode*397) ^ Alt.GetHashCode();
                hashCode = (hashCode*397) ^ Keycode;
                return hashCode;
            }
        }

        public static bool operator ==(Hotkey a, Hotkey b)
        {
            if(ReferenceEquals(a, null) && ReferenceEquals(b, null)) {
                return true;
            }
            if(ReferenceEquals(a, null) || ReferenceEquals(b, null)) {
                return false;
            }
            return a.Equals(b);
        }

        public static bool operator !=(Hotkey a, Hotkey b)
        {
            return !(a == b);
        }
    }
}
