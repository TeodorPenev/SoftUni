using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem3
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        string dot = new string('.', n);
        string asterix = new string('*',1);
        Console.WriteLine(dot+asterix+dot);

        int dotMCount=n-1;
        int dotMCountMid = 1;
        for (int i = 0; i < n/2-1; i++)
        {
         string dotM = new string('.', dotMCount);
         string dotMidle = new string('.', dotMCountMid);
        string asterixM = new string('*',1);
        Console.WriteLine(dotM+asterix+dotMidle+asterix+dotM);
        dotMCount--;
        dotMCountMid += 2;
        }

        //middle
        string dotMM = new string('.', n-1);
        string asterixMM = new string('*',((2*n+1) - (n-1))/2);
        Console.WriteLine(asterixMM+dotMM+asterixMM);

        int dotMMMC = 1;
        int dotMMMCMiddleC = (2 * n + 1) - 4;
        for (int i = 0; i < n/2-1; i++)
        {
            string dotMMM = new string('.', dotMMMC);
            string asterixMMM = new string('*', 1);
            string dotMMMMidle = new string('.', dotMMMCMiddleC);
            Console.WriteLine(dotMMM+asterix+dotMMMMidle+asterix+dotMMM);
            dotMMMC++;
            dotMMMCMiddleC = dotMMMCMiddleC - 2;
        }
        int dotEndStartCount = n / 2;
        //end
        string dotEStart = new string('.', dotEndStartCount);
        string asterixEnd = new string('*', 1);
        string dotEMiddle = new string('.', n/2-1);
        Console.WriteLine(dotEStart+asterixEnd+dotEMiddle+asterixEnd+dotEMiddle+asterixEnd+dotEStart);
        dotEndStartCount--;

        int dotEMiddleEMiddleC =1;
        for (int i = 0; i < n/2-1; i++)
        {
            string dotEStartE = new string('.', dotEndStartCount);
            string asterixEndE = new string('*', 1);
            string dotEMiddleE = new string('.', n / 2 - 1);
            string dotEMiddleEMiddle = new string('.',dotEMiddleEMiddleC);
           
            Console.WriteLine(dotEStartE + asterixEndE + dotEMiddleE + asterixEnd+dotEMiddleEMiddle+asterixEndE + dotEMiddleE + asterixEndE + dotEStartE);
            dotEndStartCount--;
            dotEMiddleEMiddleC+=2;
        }
        //bottom
        string dotB = new string('.', n-1);
        string asterixB = new string('*',((2*n+1)-(n-1))/2);
        Console.WriteLine(asterixB+dotB+asterixB);
    }
    
}

