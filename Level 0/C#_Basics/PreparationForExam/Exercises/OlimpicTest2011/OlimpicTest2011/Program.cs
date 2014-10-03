using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicTest2011
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTest = int.Parse(Console.ReadLine());
            int nLine = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < nTest; i++)
            {
                for (int y = 0; i < nLine; y++)
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    sum = b - a;
                }
            }

        }
    }
}
