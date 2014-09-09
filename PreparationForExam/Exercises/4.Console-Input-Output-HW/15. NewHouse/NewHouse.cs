//Problem 15.	* – New House
//This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.  

using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int starIncrease = 0;
        int linesDecrease =0;
        for (int i = 0; i < n/2+1; i++)
        {
            
            string lines = new string('-',Math.Abs(n/2 -linesDecrease++ ));
            string star = new string('*',1+ 2*starIncrease++);
            Console.WriteLine("{0}{1}{0}",lines,star);
            if (lines == "")
                for (int i1 = 0; i1 < n; i1++)
                {
                    string stick = new string('|', 1);
                    string starEnd = new string('*', n - 2);
                    Console.WriteLine("{0}{1}{0}", stick, starEnd);
                    
                }
            
        }
    }

}

