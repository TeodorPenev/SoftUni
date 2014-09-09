//Problem 15.	* Joro, the Football Player
//This problem comes from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.

using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        char l = char.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int result = 0;
        p = p*0.5;
        double w = (52-h);
            w= w*2/3;
            w = w + h;
        if (l=='t')
        {
            result += 3;
            int r = (int)(p+w+result);

            Console.WriteLine(r);
        }
        else
        {
            int r = (int)(p + w);
            Console.WriteLine(r);
        }

    }
}

