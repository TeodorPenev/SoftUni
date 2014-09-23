using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c : ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("The sum of a,b,c is : {0}",a+b+c);
        Console.WriteLine();
    }
}

