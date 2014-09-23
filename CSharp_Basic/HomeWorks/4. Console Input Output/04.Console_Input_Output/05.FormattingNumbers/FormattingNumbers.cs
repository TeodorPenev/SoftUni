using System;
class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        string hex = "";
        string bin = "";
        if (0 <= a && a <= 500)
        {
            hex = Convert.ToString(a, 16);
            bin = Convert.ToString(a, 2).PadLeft(10, '0');
        }
        else
        {
            Console.WriteLine("You enter invalid value of a!");
        }
        if (c >0.500)
        {
            Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:0.###}|", hex.ToUpper(), bin, b, c);
        }
        if (c<1)
        {
            Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|", hex.ToUpper(), bin, b, c);
        }
        
    }
}

