using System;
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Random rnd = new Random();
            int numR;
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",numR = rnd.Next(min, max));
            }

        }
    }

