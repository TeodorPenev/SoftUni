﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public interface IHtmlRenderer
    {
        void RenderHtml(TextWriter writer);
    }
}
