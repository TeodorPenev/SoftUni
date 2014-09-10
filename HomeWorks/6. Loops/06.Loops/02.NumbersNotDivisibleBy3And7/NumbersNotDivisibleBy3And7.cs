using System;
class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <=n ; i++)
        {
            if (i % 7==0 || i % 3 ==0)
            {
                continue;
            }
            Console.Write("{0} ",i);
        }
    }
}

