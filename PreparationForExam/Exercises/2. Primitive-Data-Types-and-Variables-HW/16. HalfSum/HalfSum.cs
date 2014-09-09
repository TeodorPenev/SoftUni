//Problem 16.	* Half Sum
//This problem comes from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.

using System;
    class HalfSum
{
    static void Main()
    {
        ushort n = ushort.Parse(Console.ReadLine());
        int aR = 0;
        int bR = 0;
        
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            aR = aR+a; 
        }
        for (int i = 0; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            bR = bR + b;
        }
        int result = aR - bR; 
        if (aR == bR)
        {
            Console.WriteLine("Yes, sum={0}",aR);
        }
        else
        {
            result = Math.Abs(result);
            Console.WriteLine("No, diff={0}", result);
        }
    }
}

