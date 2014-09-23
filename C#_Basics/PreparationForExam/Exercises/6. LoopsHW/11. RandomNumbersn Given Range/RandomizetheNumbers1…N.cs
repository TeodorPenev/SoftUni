using System;

class RandomizetheNumbers
{
    static void Main()
    {
        int random=0;
        int n = int.Parse(Console.ReadLine());
        Random numb = new Random();
        for (int i = 1; i <= n; i++)
        {  
            random = numb.Next(1,n);
            Console.Write("{0} ",random);
        }
        
    }
}


