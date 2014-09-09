//Problem below are given from Variant 5 of C# Basics Practical Exam (12 April 2014 Morning).
using System;
namespace _15.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int middleZero = 0;
            int dotDec = 1;
            int dotInc = 0;
            int dotInc1 = 0;
            int dotInc2 = 1;
            for (int i = 0; i < n-1; i++)
            {
                if (i == 0)
                {
                    string dot = new string('.',(n - 1) / 2);
                    string asterik = new string('*', 1);
                    Console.WriteLine("{0}{1}{0}",dot,asterik);
                }
                if (i < n/2-1)
                {
                    string dot = new string('.',((n-1) / 2)-dotDec++);
                    string asterik = new string('*', 1);
                    string middleDot = new string('.', 1 + dotInc1++*2);
                    string middleEnd = new string('*', n);
                    Console.WriteLine("{0}{1}{2}{1}{0}",dot,asterik,middleDot);
                    
                }
                if (i==n/2-1)
                {
                    string middleEnd = new string('*', n);
                    Console.WriteLine(middleEnd);
                }
                if (i>n/2)
                {
                    string dot = new string('.', n/4);
                    string asterik = new string('*', 1);
                    string middleDot = new string('.', n-(((n/4)*2)+2));
                    Console.WriteLine("{0}{1}{2}{1}{0}", dot, asterik, middleDot);
                    
                }
                if (i==n-2)
                {
                    string dot = new string('.', n/4);
                    string asterik = new string('*', n-(((n/4)*2)));
                    Console.WriteLine("{0}{1}{0}",dot,asterik);
                }
               
            }
            
        }
    }
}
