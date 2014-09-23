using System;


class SumOf5Numbers
{
    
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        double n1 = double.Parse(num[0]);
        double n2 = double.Parse(num[1]);
        double n3 = double.Parse(num[2]);
        double n4 = double.Parse(num[3]);
        double n5 = double.Parse(num[4]);
        Console.WriteLine("Sum : {0}",n1+n2+n3+n4+n5);
    }
}

