//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.
using System;

namespace _19.TheExplorer
{
    class TheExplorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3 = 1;
            for (int i = 0; i < n; i++)
            {
                if (i==0 || i+1==n)
                {
                    string line = new string('-', (n - 1) / 2);
                    string asterik = new string('*', 1);
                    Console.WriteLine("{0}{1}{0}", line, asterik);
                }
                if (i!=0 && i<n/2)
                {
                    string line = new string('-',Math.Abs( n / 2-n2));
                    n2++;
                    string asterik = new string('*', 1);
                    string mLine = new string('-', 1 + 2 * n1++);
                    Console.WriteLine("{0}{1}{2}{1}{0}", line, asterik, mLine);    
                }
                if (i == n/2)
                {
                    string asterik = new string('*', 1);
                    string line = new string('-', n - 2);
                    Console.WriteLine("{0}{1}{0}",asterik,line);
                }
                if (i!=0 && i>n/2 && i+1!=n)
                {
                    string line = new string('-',n3++);
                    string asterik = new string('*', 1);
                    string mLine = new string('-',Math.Abs( 1 + 2 * n1---2));
                    Console.WriteLine("{0}{1}{2}{1}{0}", line, asterik, mLine);
                    
                }
              
            }
        }
    }
}
