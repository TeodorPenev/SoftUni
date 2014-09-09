//Problem 14.	**– Sum of Elements
//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  

using System;
class SumOfElements
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] nums = inputLine.Split(' ');
        int sum = 0;
        int maxE = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int element = int.Parse(nums[i]);
            sum = sum + element;

            if (element > maxE)
            {
                maxE = element;
            }
        }
        if (maxE * 2 == sum)
        {
            Console.WriteLine("Yes, sum={0}", maxE);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(sum - 2*maxE));
        }
    }
}

