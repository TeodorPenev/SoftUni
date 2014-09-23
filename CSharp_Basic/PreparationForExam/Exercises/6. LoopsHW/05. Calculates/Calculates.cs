using System;
class Calculates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        double power = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            power = Math.Pow(x, i);
            sum = sum + factorial/power;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}

