using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.StringDisperser
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StringDisperser args1 = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser args2 = new StringDisperser("gosho", "pesho", "tanio");

            Console.WriteLine("equals override");
            bool test1 = Equals(args1, args2);       //equals override
            Console.WriteLine(test1);


            Console.WriteLine("operators override");
            bool test2 = args1 != args2;             //operators override
            Console.WriteLine(test2);

            Console.WriteLine("IClonable");
            StringDisperser test3 = (StringDisperser)args1.Clone();        //ICloneable
            Console.WriteLine(test3);

            Console.WriteLine("IComparable");
            Array test4 = new []      //IComparable
            {
                new StringDisperser("gosho", "pesho", "gosho", "pesho", "tanio"),
                new StringDisperser("gosho", "pesho", "tanio", "gosho", "pesho", "tanio","gosho", "pesho", "tanio","gosho", "pesho", "tanio"),
                new StringDisperser("gosho", "pesho", "tanio","gosho", "pesho", "tanio","gosho", "pesho", "tanio"),
                new StringDisperser("gosho", "pesho", "tanio")
            };

            Array.Sort(test4);
            foreach (var arg in test4)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine("IEnumerable");
            foreach (var ch in args1)               //IEnumerable
            {
                Console.Write(ch + " ");
            }

        }
    }
}
