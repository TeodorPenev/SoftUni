using System;

namespace _01.Shapes.Models
{
    class Circle:BasicShape
    {
        private double radius;

        public Circle(double radius) : base(1,1)
        {
            this.radius = radius;
        }

        public double Radius {
            get { return this.radius; }

            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("The radius cannot be negative!");
                }
                this.radius = value;
            }

        }

        public override double CalculateArea()
        {
           Console.WriteLine("Circle class area :");
           return (Math.PI*radius*radius);
        }

        public override double CalculatePerimeter()
        {
            Console.WriteLine("Circle class perimeter :");
            return (2*Math.PI*radius);
        }
    }
}
