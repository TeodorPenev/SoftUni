using System;
namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double temp = 0;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine(a + " " + b);

        }
    }
}
