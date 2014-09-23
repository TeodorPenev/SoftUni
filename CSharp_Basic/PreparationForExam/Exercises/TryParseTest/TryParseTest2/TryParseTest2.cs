using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseTest2
{
    class TryParseTest2
    {
        static void Main(string[] args)
        {
            checkRevParse(Console.ReadLine());
        }
        static void checkRevParse(string strCheck)
        {
            int num1 = 0;
            bool n1 = int.TryParse(strCheck, out num1);
            for (int i = 0; n1 == false && i < 100; i++)
            {
                Console.WriteLine("You enter ivalid value.Please try again!");
                n1 = int.TryParse(Console.ReadLine(), out num1);
            }
            Console.WriteLine(num1);
        }
    }
}
