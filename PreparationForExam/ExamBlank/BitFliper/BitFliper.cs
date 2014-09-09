using System;
class BitFliper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        ulong one = 7L;

        for (int i = 61; i >= 0; i--)
        {
            ulong mask = (num & one << i) >> i;
            if (mask == 7)
            {
                num = (num & ~(one << i));
                i = i - 2;
            }
            if (mask == 0)
            {
                num = (num | (one << i));
                i = i - 2;
            }
        }
        Console.WriteLine(num);
    }
}

