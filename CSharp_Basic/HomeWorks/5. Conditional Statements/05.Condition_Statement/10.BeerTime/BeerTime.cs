using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Please enter a time : ");
        string time = Console.ReadLine();
        DateTime timeNow = DateTime.ParseExact(time, "h:mm tt", CultureInfo.InvariantCulture);
        string start = "1:00 PM";
        string end = "3:00 AM";
        DateTime startTime =DateTime.ParseExact(start,"h:mm tt",CultureInfo.InvariantCulture);
        DateTime endTime = DateTime.ParseExact(end, "h:mm tt", CultureInfo.InvariantCulture);
        if (timeNow<startTime && timeNow>endTime )
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}

