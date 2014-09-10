using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = (n / 100)%10;
        bool thirdD7 = false;
        if (n == 7)
        {
            thirdD7 = true;
        }
        Console.WriteLine("Third digit 7? : {0}",thirdD7);
    }
}

