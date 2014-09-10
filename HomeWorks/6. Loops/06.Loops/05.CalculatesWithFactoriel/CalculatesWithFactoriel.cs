using System;
class CalculatesWithFactoriel
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double Factoriel = 1;
        double powValue = 0;
        double sum = 1;
        for (double i = 1; i <=n; i++)
        {
            Factoriel = Factoriel * i;
            powValue = Math.Pow(x, i);
            sum = sum + (Factoriel / powValue);
        }
        Console.WriteLine("{0:F5}",sum);
    }
}

