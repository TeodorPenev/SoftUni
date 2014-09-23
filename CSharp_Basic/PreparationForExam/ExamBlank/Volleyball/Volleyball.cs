using System;
class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double totalWeekends = 48;
        totalWeekends = totalWeekends - hometown;
        double normalWeekend = totalWeekends * (3.0 / 4.0);
        normalWeekend = normalWeekend + holidays * (2.0 / 3.0);
        normalWeekend = normalWeekend + hometown;
        if (leap == "leap")
        {
            normalWeekend = normalWeekend + (normalWeekend * 0.15);
            Console.WriteLine((int)(normalWeekend));
        }
        else
        {
            Console.WriteLine((int)(normalWeekend));
        }


    }
}

