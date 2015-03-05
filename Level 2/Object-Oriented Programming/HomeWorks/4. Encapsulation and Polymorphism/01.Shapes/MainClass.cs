using System;
using System.Collections.Generic;
using _01.Shapes.Models;

namespace _01.Shapes
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var shapes = new List<BasicShape>();
            BasicShape triangle1 = new Triangle(1,2,3,33,33);
            BasicShape rectangle1 = new Rectangle(12,12);
            Console.WriteLine(triangle1.CalculateArea());
            Console.WriteLine(rectangle1.CalculateArea());
        }
    }
}
