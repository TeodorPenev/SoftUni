//Problem below are given from Variant 5 of C# Basics Practical Exam (12 April 2014 Morning).
using System;

class Pairs
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(' ');
        
        int firstV = int.Parse(n[0]);
        int secondV = int.Parse(n[1]);
        int sum = firstV + secondV;
        int sum1 = 0;
        int diff = 0;
        int maxDiff = 0;
        for (int i = 2; i < n.Length-1; i=i+2) 
        {

            firstV = int.Parse(n[i]);
            secondV = int.Parse(n[i+1]);
            sum1 = firstV + secondV;
            diff =Math.Abs(sum - sum1);
            maxDiff = Math.Max(diff, maxDiff);
        }
        if (diff == 0)
        {
            Console.WriteLine("Yes, value={0}",sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}",maxDiff);
        } 
    }
}
