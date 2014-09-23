//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter	area
//3	     4	       14	     12
//2.5	 3	       11	    7.5
//5	     5	       20	     25

using System;
class Rectangles
{
    static void Main()
    {
        double w =double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter : {0}  /// Area : {1} ",(w*2)+(h*2),w * h);
    }
}

