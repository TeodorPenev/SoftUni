using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Component nvidia = new Component("GTX580","fabricOvercloack",350.0m);
            Console.WriteLine(nvidia);
        }
    }
}
