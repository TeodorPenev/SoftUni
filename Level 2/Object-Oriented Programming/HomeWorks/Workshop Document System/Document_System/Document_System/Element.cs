using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Document_System
{
    public abstract class Element
    {
        public IList<Element> ChildElement { get; set; }
    }
}
