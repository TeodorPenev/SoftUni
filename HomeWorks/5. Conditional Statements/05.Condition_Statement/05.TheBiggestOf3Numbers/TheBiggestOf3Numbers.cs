using System;
class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Biggest = {0}", a);
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("Biggest = {0}", b);
            }
        }
        if (c > a)
        {
            if (c > b)
            {
                Console.WriteLine("Biggest = {0}", c);
            }
        }
    }
}

