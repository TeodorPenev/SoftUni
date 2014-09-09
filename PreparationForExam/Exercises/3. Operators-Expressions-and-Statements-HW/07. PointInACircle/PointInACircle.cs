//Problem 7.	Point in a Circle

using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (((x - 0) * (x - 0)) + ((y - 0) * (y - 0)) <= Math.Pow(2,2))
        {
            Console.WriteLine("true"); 

        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

