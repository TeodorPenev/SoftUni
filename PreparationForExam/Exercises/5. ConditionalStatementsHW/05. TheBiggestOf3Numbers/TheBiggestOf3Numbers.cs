using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggerFromAB = 0;
        if ((a > b) || (a < b) || (a == b))
        {
            if (a > b)
            {
                biggerFromAB = a;
            }
            else if (a < b)
            {
                biggerFromAB = b;
            }
            else if (a == b)
            {
                biggerFromAB = a;
            }
        }
        Console.WriteLine(Math.Max(biggerFromAB,c));
    }
}

