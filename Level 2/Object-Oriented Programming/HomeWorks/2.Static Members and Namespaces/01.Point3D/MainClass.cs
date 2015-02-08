using System;

namespace _01.Point3D
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D firstP = new Point3D(11.11,22.22,33.33);
            Point3D secondP = new Point3D(0.0, 1.1, 2.2);

            Console.WriteLine(firstP);
            Console.WriteLine(secondP);

            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
