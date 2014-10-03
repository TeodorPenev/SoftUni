using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstD = new DateTime();
        firstD = DateTime.ParseExact((Console.ReadLine()), "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondD = new DateTime();
        secondD = DateTime.ParseExact((Console.ReadLine()), "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime saveFirst;

        int count = 0;
        if (firstD > secondD)
        {
            for (int i = 1; i >= 1; i++)
            {
                count++;
                saveFirst = secondD.AddDays(count);

                if (saveFirst == firstD)
                {
                    break;
                }
            }
        }
        else if (firstD < secondD)
        {
            for (int i = 1; i >= 1; i++)
            {
                count++;
                saveFirst = firstD.AddDays(count);

                if (saveFirst == secondD)
                {
                    break;
                }
            }
        }

        if (firstD > secondD)
        {
            Console.WriteLine("-{0}",count);
        }
        else
        {
            Console.WriteLine(count);
        }          
    }

}


