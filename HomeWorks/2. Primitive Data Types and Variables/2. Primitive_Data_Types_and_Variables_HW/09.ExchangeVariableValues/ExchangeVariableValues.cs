using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange a={0} & b={1}",a,b);
        int valueB = b;
        int valueA = a;
        a =valueB;
        b = valueA;
        Console.WriteLine("After exchange a={0} & b={1}", a, b);
    }
}

