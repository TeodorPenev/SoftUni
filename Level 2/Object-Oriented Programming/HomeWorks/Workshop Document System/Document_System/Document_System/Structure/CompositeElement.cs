using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Document_System.Utils;

namespace Document_System.Structure
{
    public class CompositeElement : Element
    {
        protected IList<Element> ChildElement { get; set; }

        public CompositeElement()
        {
            this.ChildElement = new List<Element>();
        }

        public CompositeElement(params Element[] elements)
            :this()
        {
            this.Add(elements);
        }

        public void Add(params Element[] elements)
        {
            foreach (var element in elements)
            {
                this.ChildElement.Add(element);
            }
        }

        public override void RenderHtml(TextWriter writer)
        {
            foreach (var element in this.ChildElement)
            {
                element.RenderHtml(writer);
            }
        }

        public override void RenderText(TextWriter writer)
        {
            foreach (var element in this.ChildElement)
            {
                element.RenderText(writer);
            }
        }
    }
}
