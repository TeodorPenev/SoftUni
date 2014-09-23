using System;

class PrintADeckOf52Cards
{
    static void Main()
        {                        //The Easy Way:

        //string[] cardsN = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] cardsSymbol = { "♥", "♦", "♠", "♣" };
        //{
        //    for (int i = 0; i <= 12; i++)
        //    {
        //        Console.Write("{0}{1} ", cardsN[i], cardsSymbol[0]);
        //        Console.Write("{0}{1} ", cardsN[i], cardsSymbol[1]);
        //        Console.Write("{0}{1} ", cardsN[i], cardsSymbol[2]);
        //        Console.Write("{0}{1} ", cardsN[i], cardsSymbol[3]);
        //        Console.WriteLine();

                                 //The Hardway
        string card = "2";
        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                Console.Write(i);
                card = Convert.ToString(i);
            }
            else if (i == 11)
            {
                card = "J";
                Console.Write(card);
            }
            else if (i == 12)
            {
                card = "D";
                Console.Write(card);
            }
            else if (i == 13)
            {
                card = "K";
                Console.Write(card);
            }
            else if (i == 14)
            {
                card = "A";
                Console.Write(card);
            }
            for (int face = 1; face <= 4; face++)
            {
                switch (face)
                {
                    case 1:
                        Console.Write("♣ ");
                        Console.Write(card);
                        break;
                    case 2:
                        Console.Write("♦ ");
                        Console.Write(card);
                        break;
                    case 3:
                        Console.Write("♥ ");
                        Console.Write(card);
                        break;
                    case 4:
                        Console.WriteLine("♠");
                        break;

                }
            }
        }
    }
}
     
    
       