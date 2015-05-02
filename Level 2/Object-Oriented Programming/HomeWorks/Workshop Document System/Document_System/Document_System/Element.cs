using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public abstract class Element : IHtmlRenderer,ITextRenderer
    {
        public abstract void RenderHtml(TextWriter writer);

        public abstract void RenderText(TextWriter writer);

        public string AsHTML
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderHtml(writer);
                return writer.ToString();
            }
        }

        public string AsText
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderText(writer);
                return writer.ToString();
            }
        }

        public override string ToString()
        {
            return this.AsText;
        }
    }
}
