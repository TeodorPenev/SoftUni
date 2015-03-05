namespace _01.Shapes.Models
{
    class Rectangle:BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (Width * Height);
        }

        public override double CalculatePerimeter()
        {
            return 2*(Width + Height);
        }
    }
}
