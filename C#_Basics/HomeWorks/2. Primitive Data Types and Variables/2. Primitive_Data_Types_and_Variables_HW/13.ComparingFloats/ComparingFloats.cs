using System;
class ComparingFloats
{
    static void Main()
    {
        double n1 = -4.999999;
        double n2 = -4.999998;
        double precision = 0.000001;
        double sub = Math.Abs(n1 - n2);
        bool result = sub < precision ;
        Console.WriteLine(result);
    }
}

