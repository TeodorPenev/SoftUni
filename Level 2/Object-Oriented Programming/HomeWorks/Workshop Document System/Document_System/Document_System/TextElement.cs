using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Document_System
{
    public class TextElement : Element
    {
        public string Text { get; set; }

        public Font Font { get; set; }

        public TextElement(string text, Font font = null)
        {
            this.Text = text;
            this.Font = font;
        }

        public override void RenderHtml(TextWriter writer)
        {
            if (this.Font != null)
            {
            writer.Write(this.Text.HtmlEncode());
            }
            writer.Write(this.Text.HtmlEncode());
        }
    }
}
