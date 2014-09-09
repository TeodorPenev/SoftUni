using System;
class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        int dorm = floors * flats;
        double lampCons = 100.53;
        double compCons = 125.90;
        double overalWats = 0;
        string hoursStr = "";
        string minutesStr = "";
        if (time.Length == 4)
        {
            hoursStr = "" + time[0];
            minutesStr = "" + time[2] + time[3];
        }
        else
        {
            hoursStr = "" + time[0] + time[1];
            minutesStr = "" + time[3] + time[4];
        }
        int hoursI = int.Parse(hoursStr);
        int minutesI = int.Parse(minutesStr);
        DateTime start = new DateTime(1, 1, 1, hoursI, minutesI, 0);
        DateTime firstStart = new DateTime(1, 1, 1, 14, 00, 0);
        DateTime firstEnd = new DateTime(1, 1, 1, 18, 59, 0);

        DateTime secondStart = new DateTime(1, 1, 1, 19, 00, 0);
        DateTime secondEnd = new DateTime(1, 1, 1, 23, 59, 0);

        DateTime thirdStart = new DateTime(1, 1, 1, 00, 00, 0);
        DateTime thirdEnd = new DateTime(1, 1, 1, 8, 59, 0);

        DateTime offStart = new DateTime(1, 1, 1, 9, 00, 0);
        DateTime offEnd = new DateTime(1, 1, 1, 13, 59, 0);

        if (start>=offStart && start<=offEnd)
        {
            Console.WriteLine("0 Watts");
        }

        if (start>=firstStart && start<=firstEnd)
        {
            overalWats = dorm * (2 * lampCons + 2 * compCons);
            Console.WriteLine("{0} Watts", (int)overalWats);
        }

        if (start >=secondStart && start <= secondEnd)
        {
            overalWats = dorm * (7 * lampCons + 6 * compCons);
            Console.WriteLine("{0} Watts", (int)overalWats);
        }

        if (start >= thirdStart && start <= thirdEnd)
        {
            overalWats = dorm * (1 * lampCons + 8 * compCons);
            Console.WriteLine("{0} Watts", (int)overalWats);
        }
        
    }
}

