using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public abstract class Element : IHtmlRenderer
    {
        public abstract void RenderHtml(TextWriter writer);

        public string AsHTML
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderHtml(writer);
                return writer.ToString();
            }
        }
    }
}
