using System;

namespace _01.Shapes.Models
{
    class Rectangle:BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            Console.WriteLine("Rectangle class area :");
            return (Width * Height);
        }

        public override double CalculatePerimeter()
        {
            Console.WriteLine("Rectangle class perimeter :");
            return 2*(Width + Height);
        }
    }
}
