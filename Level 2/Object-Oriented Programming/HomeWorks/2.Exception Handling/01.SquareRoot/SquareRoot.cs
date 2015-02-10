using System;
using System.Globalization;
using System.Runtime.Remoting.Services;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Integer Number: ");
                int numI = int.Parse(Console.ReadLine());
                string numStr = Convert.ToString(numI);
                double numD = double.Parse(numStr);
                double sqrareNum =Math.Sqrt(numD);
                
                if (numI < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Square root: {0}",sqrareNum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }


        }
    }
}
