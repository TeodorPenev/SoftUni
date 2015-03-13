using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class MainClass
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>();
            test.Add(22);
            test.Add(33);
            test.Add(44);
            test.Add(55);
            Console.WriteLine(test);

            test.RemoveAt(1);
            Console.WriteLine(test);

            test.FindElementIndex(2);
            Console.WriteLine(test);

            Console.WriteLine(test.Countains(100));

            Console.WriteLine(test.Max() + "\n");
            Console.WriteLine(test.Min() + "\n");

            test.Clear();
            Console.WriteLine(test);

            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("Version: {0}", (allAttributes[0] as VersionAttribute).Version);
        }
    }
}
