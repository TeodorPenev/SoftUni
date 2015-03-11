using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultimediaStore.CoreLogic
{
    class InsufficientSuppliesException : Exception
    {
        public InsufficientSuppliesException(string message):base(message)
        {
        }
    }
}
