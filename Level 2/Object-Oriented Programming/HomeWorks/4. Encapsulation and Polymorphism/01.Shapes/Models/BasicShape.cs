using System;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Models
{
    abstract class  BasicShape:IShape
    {
        private double width;
        private double height;

        public BasicShape(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get { return this.width; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Value cannot be negative!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Value cannot be negative!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
