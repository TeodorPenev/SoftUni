using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = n1; i <= n2 ; i++)
        {
            if (i%5==0)
            {
                count++;
                
            }

        } 
        Console.WriteLine(count);
    }
}
