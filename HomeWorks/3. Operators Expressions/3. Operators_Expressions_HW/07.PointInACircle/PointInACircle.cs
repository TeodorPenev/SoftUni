using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("Please enter a coordinates of x : ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter a coordinates of y : ");
        double y = double.Parse(Console.ReadLine());
        bool inside = false;
        if (Math.Pow(x-0,2)+Math.Pow(y-0,2)<Math.Pow(2,2))
        {
            inside = true;
        }
        Console.WriteLine("Given point (x,y) is inside a circle K({0,0},2). = {0}",inside);
    }
}

