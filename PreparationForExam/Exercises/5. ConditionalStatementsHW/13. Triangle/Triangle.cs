//Problem below are given from Variant 5 of C# Basics Practical Exam (12 April 2014 Morning).
using System;

class Triangle
{
    static void Main()
    {
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());
        double DistanceAB = 0;
        double DistanceBC = 0;
        double DistanceAC = 0;
        DistanceAB = (Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2)));
        DistanceBC = (Math.Sqrt(Math.Pow(bX - cX, 2) + Math.Pow(bY - cY, 2)));
        DistanceAC = (Math.Sqrt(Math.Pow(cX - aX, 2) + Math.Pow(cY - aY, 2)));
        double a = DistanceAB;
        double b = DistanceBC;
        double c = DistanceAC;
        double p = 0;
        double area = 0;
        if (a+b>c && b+c>a && a+c>b)
        {
            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}",a);
        }
    }
}

