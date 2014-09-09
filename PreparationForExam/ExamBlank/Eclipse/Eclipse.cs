using System;
class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string topEmpty = new string(' ', 1);
        string topStar = new string('*', n * 2 - 2);
        string topMiddleEmpty = new string(' ', n + 1);
        Console.WriteLine(topEmpty + topStar + topMiddleEmpty + topStar + topEmpty);
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            string star = new string('*', 1);
            string dash = new string('/', n * 2 - 2);
            string empty = new string(' ', n - 1);
            Console.WriteLine(star + dash + star + empty + star + dash + star);
        }
        string starM = new string('*', 1);
        string dashM = new string('/', n * 2 - 2);
        string emptyM = new string('-', n - 1);
        Console.WriteLine(starM + dashM + starM + emptyM + starM + dashM + starM);
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            string star = new string('*', 1);
            string dash = new string('/', n * 2 - 2);
            string empty = new string(' ', n - 1);
            Console.WriteLine(star + dash + star + empty + star + dash + star);
        }
        Console.WriteLine(topEmpty + topStar + topMiddleEmpty + topStar + topEmpty);

    }
}

