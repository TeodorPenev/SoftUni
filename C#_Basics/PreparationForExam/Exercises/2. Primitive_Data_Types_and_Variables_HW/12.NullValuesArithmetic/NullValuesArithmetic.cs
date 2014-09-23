using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? n1 = null;
        double? n2 = null;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        n1 = 5;
        n2 = 5.55;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
    }
}

