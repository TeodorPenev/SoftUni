//Problem 15.	* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

namespace _15.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Please insert your birthday (mm/dd/yyyy) : ");
            DateTime myBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Your age now is : "); 
            Console.WriteLine(DateTime.Now.Year - myBirth.Year);
            Console.Write("After 10 years your age will be: {0}", DateTime.Now.Year - myBirth.Year + 10);
            Console.WriteLine();
        }
    }
}
