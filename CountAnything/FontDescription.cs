using System;
using System.Drawing;

namespace CountAnything {
    [Serializable]
    public class FontDescription {
        public string Family { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }

        public FontDescription(string family, float size, FontStyle style)
        {
            Family = family;
            Size = size;
            Style = style;
        }

        public Font CreateFont()
        {
            return new Font(Family, Size, Style);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Family, Size, Style);
        }

        public static FontDescription FromFont(Font font)
        {
            return new FontDescription(font.FontFamily.Name, font.Size, font.Style);
        }
    }
}
