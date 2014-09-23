//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  
using System;
class WorkHours
{
    static void Main()
    {
        double hours = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());
        productivity = productivity / 100;
        double normalDaysHours = 0;
        double normalDaysHoursAndProd = 0;
        double result = 0;
        days = days - (days * 0.10);
        normalDaysHours = days * 12;
        normalDaysHoursAndProd = (int)(normalDaysHours * productivity);

        if (normalDaysHoursAndProd -hours  < 0 )
        {
            result = normalDaysHoursAndProd - hours;
            Console.WriteLine("No");
            Console.WriteLine(result);
        }
        else
        {
            result = normalDaysHoursAndProd - hours;
            Console.WriteLine("Yes");
            Console.WriteLine(result);
        }
    }
}

