using System;
class ExamSchedule
{
   
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durH = int.Parse(Console.ReadLine());
        int durM = int.Parse(Console.ReadLine()); 
        DateTime dtStart = new DateTime(2014, 1, 1, startHour, startMinutes,0,0);
        if (partOfDay == "PM")
        {
            dtStart = dtStart.AddHours(durH+12).AddMinutes(durM);
        }
        else
        {
            dtStart = dtStart.AddHours(durH).AddMinutes(durM);
        }
        string strFinal = string.Format("{0:hh:mm:tt}", dtStart);
        Console.WriteLine(strFinal);
          
        
        //Difference Between Dates

        //string firstStr = Console.ReadLine();
        //string secondStr = Console.ReadLine();
        //DateTime firstD = DateTime.ParseExact(firstStr, "d.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //DateTime secondD = DateTime.ParseExact(secondStr, "d.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //TimeSpan dayResult = secondD - firstD;
        //Console.WriteLine(dayResult.Days);

    }
}