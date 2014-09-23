using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double totalWeekends = 52;
        totalWeekends = totalWeekends - hometown;
        double normalWekend = totalWeekends * (2.0 / 3.0);
        normalWekend = normalWekend + hometown;
        normalWekend = normalWekend + (holidays / 2.0);
        if (leap == "t")
        {
            normalWekend = normalWekend + 3;
            Console.WriteLine((int)normalWekend);
        }
        else
        {
            Console.WriteLine((int)normalWekend);
        }
    }
}

