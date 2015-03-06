using System;
using _01.Shapes.Models;

namespace _01.Shapes
{
    class MainClass
    {
        static void Main(string[] args)
        {
            BasicShape[] shapes = new BasicShape[3];

            shapes[0] = new Triangle(1, 2, 3);
            shapes[1] = new Rectangle(12,12);
            shapes[2] = new Circle(4);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
            }
        }
    }
}
