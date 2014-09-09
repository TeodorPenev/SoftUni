using System;
class Arrow
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //top
        string dot = new string('.', n / 2);
        string dash = new string('#', n);
        Console.WriteLine(dot + dash + dot);
        //after
        for (int i = 0; i < n - 2; i++)
        {
            dot = new string('.', n / 2);
            dash = new string('#', 1);
            string midDot = new string('.', n - 2);
            Console.WriteLine(dot + dash + midDot + dash + dot);
        }
        //middle
        string mDot = new string('.', n - 2);
        string mDash = new string('#', ((((n * 2) - 1) - (n - 2)) / 2));
        Console.WriteLine(mDash + mDot + mDash);
        //bottom
        int outD = 1;
        int midD = ((n * 2) - 1) - 4;
        for (int i = 0; i < n - 2; i++)
        {
            string outDot = new string('.', outD);
            string Dash = new string('#', 1);
            string middleDots = new string('.', midD);
            Console.WriteLine(outDot + Dash + middleDots + Dash + outDot);
            outD = outD + 1;
            midD = midD - 2;
        }
        //end
        string outDotE = new string('.', n - 1);
        string DashE = new string('#', 1);
        Console.WriteLine(outDotE + DashE + outDotE);
    }
}

