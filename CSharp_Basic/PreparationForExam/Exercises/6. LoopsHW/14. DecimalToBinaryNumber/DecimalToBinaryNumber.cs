//int num = int.Parse(Console.ReadLine());
//Console.WriteLine(Convert.ToString(num, 2));
using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string result = "";

        if (number == 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            while (number > 0)
            {
                int digit = (int)number & 1;
                number >>= 1;
                result = digit.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}

