using System;
class CheckForAPlayCard
{
    static void Main()
    {
        string ch = Console.ReadLine();
        string cards = "2345678910JQKA";
        bool exist = false;
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i].ToString()==ch)
            {
                Console.WriteLine("Yes");
                exist = true;
            }
        }
        if (exist == false)
        {
            Console.WriteLine("NO");
        }
        
       
    }
}

