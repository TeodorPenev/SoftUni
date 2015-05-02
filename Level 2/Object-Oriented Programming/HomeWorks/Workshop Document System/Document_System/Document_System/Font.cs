using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public class Font : IHtmlRenderer
    {
        public const string DefaultFontName = "Arial";
        public const float DefaultFontSize = 12;
        public const FontStyle DefaultFontStyle = FontStyle.Normal;
        public static Color DefaultFontColor { get { return Color.Black; } }

        public static Font DefaultFont { get { return new Font(DefaultFontName, DefaultFontSize, DefaultFontStyle, DefaultFontColor); } }

        public string Name { get; set; }

        public float? Size { get; set; }

        public FontStyle? Style { get; set; }

        public Color Color { get; set; }

        public Font(string name = null, float? size = null, FontStyle? style = null, Color color = null)
        {
            this.Name = name;
            this.Size = size;
            this.Style = style;
            this.Color = color;
        }

        public void RenderHtml(TextWriter writer)
        {
            if (this.Name != null)
            {
                writer.Write("font-family:{0};", this.Name);
            }

            if (this.Size != null)
            {
                writer.Write("font-size:{0}pt;", this.Size);
            }

            if (this.Color != null)
            {
                writer.Write("color:");
                this.Color.RenderHtml(writer);
                writer.Write(";");
                
            }

            if ((this.Style & FontStyle.Bold) == FontStyle.Bold)
            {
                writer.Write("font-weight:bold;");
            }

            if ((this.Style & FontStyle.Italic) == FontStyle.Italic)
            {
                writer.Write("font-weight:italic;");
            }
        }
    }
}
