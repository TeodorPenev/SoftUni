using System;
namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 1;
            Console.Write("0 ");
            if (n == 2)
            {
                Console.WriteLine("1 ");
            }
            if (n == 3)
            {
                Console.WriteLine("1 1");
            }
            if (n > 3)
            {
                for (int i = 3; i < n; i++)
                {
                    if (i==3)
                    {
                        Console.Write("1 1 ");
                    }
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write("{0} ", c);
                }
            }
        }
    }
}

