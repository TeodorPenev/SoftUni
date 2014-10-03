using System;
class WorkHours
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());
        double daysDouble = 0;
        double hoursAvailible;
        int result;
        daysDouble = (double)((days - (days * 0.10)));
        hoursAvailible = Math.Floor((daysDouble * 12) * (productivity / 100));
        result = (int)hoursAvailible - hour;
        if (result < 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(result);
        }
    }
}
