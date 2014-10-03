using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter = {0}",2*(width+height));
        Console.WriteLine("Area = {0}", width * height);
    }
}

