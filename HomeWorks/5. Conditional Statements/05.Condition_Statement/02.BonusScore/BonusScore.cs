using System;
class BonusScore
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num>=0 && num<10) 
        {
            if (num>0 && num<=3)
            {
                num = num * 10;
                Console.WriteLine(num);
            }
            if (num>=4 && num<=6)
            {
                num = num * 100;
                Console.WriteLine(num);
            }
            if (num >= 7 && num <= 9)
            {
                num = num * 1000;
                Console.WriteLine(num);
            }
        }
        else
        {
            {
                Console.WriteLine("invalid score");
            }
        }
        
    }
}

