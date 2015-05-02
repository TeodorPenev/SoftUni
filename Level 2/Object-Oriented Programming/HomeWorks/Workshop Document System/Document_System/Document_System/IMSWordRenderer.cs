using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public interface IMSWordRenderer
    {
        void RenderMsWord(Stream stream);
    }
}
