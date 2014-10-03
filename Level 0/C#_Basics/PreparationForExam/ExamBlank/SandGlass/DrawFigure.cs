using System;
class DrawFigure
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //top & floor 
        string asterks = new string('*', n);
        Console.WriteLine(asterks);

        int dotCount =1;
        int astCount = n - 2;
        for (int i = 0; i < n/2-1; i++)
        {
            string dot = new string('.', dotCount);
            string midAst = new string('*', astCount);
            dotCount++;
            astCount -= 2;
            Console.WriteLine(dot+midAst+dot);
        }
        //middle 
        string middleD = new string('.', n / 2);
        string middleA = new string('*', 1);
        Console.WriteLine(middleD+middleA+middleD);

        dotCount -=1;
        astCount +=2;
        for (int i = 0; i < n / 2-1; i++)
        {
            string dot = new string('.', dotCount);
            string midAst = new string('*', astCount);
            dotCount--;
            astCount += 2;
            Console.WriteLine(dot + midAst + dot);
        }
        Console.WriteLine(asterks);

    }
}

