using System;
namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("perimeter = {0:0.00}",(2*Math.PI) * r);
            Console.WriteLine();
            Console.Write("area = {0:0.00}",Math.PI * (Math.Pow(r,2)));
            Console.WriteLine();
        }
    }
}
