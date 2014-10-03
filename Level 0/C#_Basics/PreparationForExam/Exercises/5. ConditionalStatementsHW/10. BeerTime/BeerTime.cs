using System;
using System.Globalization;
namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            DateTime enterBeerTime = DateTime.Parse(Console.ReadLine());
            string afterStr = "1:00 PM";
            string beforeStr = "3:00 AM";
            DateTime afterDate = DateTime.ParseExact(afterStr, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime beforeDate = DateTime.ParseExact(beforeStr, "h:mm tt", CultureInfo.InvariantCulture);
            if (enterBeerTime >= afterDate || enterBeerTime < beforeDate)
	        {
                Console.WriteLine("beer time");
	        }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
