using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
