using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius : ");
        double r = double.Parse(Console.ReadLine());
        double diameter = r*2;
        double perimeter = Math.PI * diameter;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Perimeter : {0:####.##} \nArea : {1:####.##}",perimeter,area);
    }
}

