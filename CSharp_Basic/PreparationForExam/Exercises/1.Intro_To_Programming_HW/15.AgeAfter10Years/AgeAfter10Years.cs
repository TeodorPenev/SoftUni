using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday in this Format(MM-DD-YYYY):");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Your age now : {0}",Math.Abs(birthday.Subtract(DateTime.Now).Days/365));
        Console.WriteLine("Your age after 10 years : {0}", Math.Abs(birthday.Subtract(DateTime.Now).Days / 365)+10);
    }
}
