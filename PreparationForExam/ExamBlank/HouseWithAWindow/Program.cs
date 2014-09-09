using System;
class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //up
        string dot = new string('.', (2 * n - 1) / 2);
        string ast = new string('*', 1);
        Console.WriteLine(dot + ast + dot);

        //roof 
        int midDotC = 1;
        for (int i = 0; i < n - 1; i++)
        {
            string dotR = new string('.', ((2 * n - 1) - (2 + midDotC)) / 2);
            string midDot = new string('.', midDotC);
            string astR = new string('*', 1);
            midDotC += 2;
            Console.WriteLine(dotR + astR + midDot + astR + dotR);
        }
        //middle 
        string midAst = new string('*', 2 * n - 1);
        Console.WriteLine(midAst);
        
        for (int i = 0; i < (n - n / 2) / 2; i++)
        {
            string outAst = new string('*', 1);
            string midDot = new string('.', (2 * n - 1) - 2);
            Console.WriteLine(outAst + midDot + outAst);
        }
        for (int i = 0; i < n - n / 2; i++)
        {
            string outAst = new string('*', 1);
            string midDot = new string('.', n / 2);
            string midAster = new string('*', n - 3);
            Console.WriteLine(outAst + midDot + midAster + midDot + outAst);
        }
        for (int i = 0; i < (n - n / 2) / 2; i++)
        {
            string outAst = new string('*', 1);
            string midDot = new string('.', (2 * n - 1) - 2);
            Console.WriteLine(outAst + midDot + outAst);
        }
        Console.WriteLine(midAst);
    }
}

