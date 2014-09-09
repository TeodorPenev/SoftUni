//Problem 17.	**– Volleyball
//This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .

using System;
class Volleyball
{
    static void Main()
    {
        string l = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int nWeekends = 48 - h;
        double weekends = nWeekends;
        weekends = weekends * 3/4;
        weekends = weekends + (p * 2/3);
        weekends = weekends + h;
        if (l == "leap")
        {
            weekends = weekends + (weekends * 0.15); 
        }
        Console.WriteLine((int)weekends);

    }
}
