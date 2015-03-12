using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [AttributeUsage(AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method,
        AllowMultiple = true)]
    public class VersionAttribute:Attribute
    {
        public VersionAttribute(double version)
        {
            this.Version = string.Format("{0:F2}", version);
        }

        public string Version { get; private set; }
    }
}
