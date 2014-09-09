using System;
class SumOfElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        long max = long.MinValue;
        long sums = 0;

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
            if (max < nums[i])
            {
                max = nums[i];
            }
            sums += nums[i];
        }
        if (max == sums - max)
        {
            Console.WriteLine("Yes, sum={0}", max);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(max - (sums - max)));

        }
    }
}
