using System;

namespace _01.Shapes.Models
{
    class Triangle:BasicShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double width, double height, double sideA, double sideB, double sideC)
            : base(width, height)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The size of the side cannot be negative!");
                }
                this.sideA = value;
            }
        }

        public double SideB
        {
            get { return this.sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the side cannot be negative!");
                }
                this.sideB = value;
            }
        }

        public double SideC
        {
            get { return this.sideC; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the side cannot be negative!");
                }
                this.sideC = value;
            }
        }

        public override double CalculateArea()
        {
            Console.WriteLine("Triangle class area :");
            return (Height * Height / 2); 
        }

        public override double CalculatePerimeter()
        {
            Console.WriteLine("Triangle class perimeter :");
            return (sideA+sideB+sideC); 
        }
    }
}
