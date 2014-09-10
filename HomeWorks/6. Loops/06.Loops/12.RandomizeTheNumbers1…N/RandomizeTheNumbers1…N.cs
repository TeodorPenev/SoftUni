using System;
class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int rndN = 0;
        
        for (int i = 0; i < num; i++)
        {
            rndN = rnd.Next(0, num+1);
            Console.Write("{0} ",rndN);
        }
    }
}

