using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string sEline = new string('-', n / 2);
        string outLine = new string('-', n / 2);
        string star = new string('*', 1);
        string mLine = new string('-', 1);
        int midCount = 1;
        Console.WriteLine(sEline + star + sEline);
        for (int i = 1; i < n / 2 + 1; i++)
        {
            outLine = new string('-', n / 2 - i);
            mLine = new string('-', midCount);
            midCount = midCount + 2;
            Console.WriteLine(outLine + star + mLine + star + outLine);
        }
        int outCount = 1;
        midCount = midCount - 2;
        for (int i = 1; i < n / 2; i++)
        {
            outLine = new string('-', outCount);
            outCount++;
            midCount = midCount - 2;
            mLine = new string('-', midCount);
            Console.WriteLine(outLine + star + mLine + star + outLine);
        }
        Console.WriteLine(sEline + star + sEline);


    }
}

