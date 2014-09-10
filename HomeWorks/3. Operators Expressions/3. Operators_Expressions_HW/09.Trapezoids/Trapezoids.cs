using System;
class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter trapezoid's side a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter trapezoid's side b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter trapezoid height : ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid Area = {0}",((a+b)/2)*h);
    }
}
