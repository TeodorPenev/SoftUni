//This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .

using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstN = 0;
        int secondN = 0;
        int firstNsum= 0;
        int secondNsum=0;
        for (int i = 0; i < n; i++)
        {
            firstN = int.Parse(Console.ReadLine());
            secondN = int.Parse(Console.ReadLine());
            firstNsum += firstN;
            secondNsum += secondN;
        }
        if (firstNsum == secondNsum)
        {
            Console.WriteLine("Yes, sum={0}", secondNsum);
	    }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(firstNsum-secondNsum));
        }
    }
}

