using System;
namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}",n1+n2+n3);
        }
    }
}
