using System;
namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("greater = {0}",Math.Max(a,b));
            Console.WriteLine();

        }
    }
}
