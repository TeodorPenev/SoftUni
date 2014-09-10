using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        max = max + 1;
        int rndNum = 0;
        Random rndInRange = new Random();
        

        for (int i = 0; i < n; i++)
        {
            rndNum = rndInRange.Next(min, max);
            Console.Write("{0} ",rndNum);
        }
    }
}

