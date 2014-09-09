using System;
class House
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int dotC =(n-1)/2-1;
        string dot = new string('.', (n-1)/2);
        string asteriks = new string('*', 1);
        //top
        Console.WriteLine(dot+asteriks+dot);
        int midDotC = 1;
        for (int i = 0; i < ((n+1)/2)-2; i++)
        {
            string dotIn = new string('.', dotC);
            string middleDot = new string('.',midDotC);
            Console.WriteLine(dotIn + asteriks + middleDot + asteriks + dotIn);
            dotC--;
            midDotC+=2;
        }
        //middle
        Console.WriteLine(asteriks = new string('*', n));
        //end
        for (int i = 0; i < n/2-1; i++)
        {
            string dotE = new string('.', n / 4);
            string middleDotE = new string('.', n - (n / 4) * 2 - 2);
            asteriks = new string('*', 1);
            Console.WriteLine(dotE + asteriks + middleDotE + asteriks + dotE);
        }
        //floor
        string dotFloor = new string('.', n/4);
        asteriks = new string('*', n-(n/4*2));
        Console.WriteLine(dotFloor+asteriks+dotFloor);
    }
}

