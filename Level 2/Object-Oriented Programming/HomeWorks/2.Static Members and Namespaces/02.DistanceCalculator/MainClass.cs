using System;

namespace _02.DistanceCalculator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 4, 2);
            Point3D point2 = new Point3D(3.2, 21.5, 6);

            Console.WriteLine(DistanceCalculator.CalculateDistance(point1,point2));
        }
    }
}
