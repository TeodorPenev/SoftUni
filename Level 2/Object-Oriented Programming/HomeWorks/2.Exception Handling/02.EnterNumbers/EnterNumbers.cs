using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
           EnterNumbers.ReadNumber(2,25);
        }
        
        public static void ReadNumber(int start, int end)
        {
            Console.Write("Please enter a number in range [{0}...{1}]: ",start,end);
            int numInRange =int.Parse(Console.ReadLine());
            if (numInRange<start || numInRange>end)
            {
                throw new FormatException("Invalid number.");
            }
           
            int tempRem = 0;
            Console.WriteLine("Enter 10 numbers a1, a2, … a10, such that 1 < a1 < … < a10 < 100: ");
            for (int i = 0; i < 10; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp > 0 && tempRem < temp)
                {
                    tempRem = temp;
                }
                else
                {
                    Console.WriteLine("You enter invalid number please try again.");
                    i--;
                }
            }
            }
            
        }
}

