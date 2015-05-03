using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Document_System.Utils;

namespace Document_System.Structure
{
    public class Heading : Element
    {
        public int HeadingSize { get; set; }
        public string Text { get; set; }

        public Heading(string text, int size = 1)
        {
            if (size <= 0 || size > 6)
            {
                throw new ArgumentOutOfRangeException("size", "The heading size should be in [1...6]");
            }
            this.HeadingSize = size;
            this.Text = text;
        }

        public override void RenderHtml(TextWriter writer)
        {
            writer.Write("<h{0}>{1}</h{0}>", this.HeadingSize, this.Text.HtmlEncode());
        }

        public override void RenderText(TextWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(this.Text.ToUpper());
        }
    }
}
