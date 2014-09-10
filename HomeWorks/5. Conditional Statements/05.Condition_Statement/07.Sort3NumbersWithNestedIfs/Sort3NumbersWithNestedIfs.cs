using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = 0;
        double middle = 0;
        double min = 0;

        if (a > b)
        {
            if (a > c)
            {
                max = a;
                if (b>c)
                {
                    middle = b;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = b;
                }
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                max = b;
                if (a > c)
                {
                    middle = a;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = a;
                }
            }
        }
        if (c > a)
        {
            if (c > b)
            {
                max = c;
                if (a > b)
                {
                    middle = a;
                    min = b;
                }
                else
                {
                    middle = b;
                    min = a;
                }
            }
        }
        Console.WriteLine("Result {0} {1} {2}",max,middle,min);
    }
}

