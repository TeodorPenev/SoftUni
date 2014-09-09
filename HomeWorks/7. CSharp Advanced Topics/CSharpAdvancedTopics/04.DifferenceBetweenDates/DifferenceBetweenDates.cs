using System;
class DifferenceBetweenDates
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        DateTime firstD = DateTime.ParseExact(firstStr, "d.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture);
        DateTime secondD = DateTime.ParseExact(secondStr, "d.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture);
        TimeSpan dayResult = secondD - firstD;
        Console.WriteLine(dayResult.Days);
    }
}

