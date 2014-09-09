//Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
//n	Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false

using System;
class PrimeNumberCheck
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if ((number > 1) && (number <= 100))
        {
            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                Console.WriteLine("The number " + number + " is prime");
            }
            else
            {
                if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 || number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0)
                {

                    Console.WriteLine("The number " + number + " is not prime");
                }
                else
                {
                    Console.WriteLine("The number " + number + " is prime");
                }
            }

        }
        else
        {
            Console.WriteLine("Number is out of range");
        }
    }
  
}

