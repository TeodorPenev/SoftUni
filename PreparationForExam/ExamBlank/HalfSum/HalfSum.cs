using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long firstSum = 0;
        long secondSum = 0;

        for (int i = 0; i < n; i++)
        {
            long tempFirst = long.Parse(Console.ReadLine());
            firstSum = firstSum + tempFirst;
        }
        for (int i = 0; i < n; i++)
        {
            long tempSecond = long.Parse(Console.ReadLine());
            secondSum = secondSum + tempSecond;
        }
        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }

    }
}