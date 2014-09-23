using System;
namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;
            double D = 0;
            D = b * b - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1=x2= {0}", x1);
            }
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
