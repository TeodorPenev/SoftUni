using System;
class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        int[] sums = new int[nums.Length / 2];
        int sumsCount = 0;
        bool isEqual = true;
        int max = int.MinValue;

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            sums[sumsCount] = nums[i] + nums[i + 1];
            i++;
            sumsCount++;
        }

        for (int i = 0; i < sums.Length - 1; i++)
        {
            if (sums[i] == sums[i + 1])
            {
                continue;
            }
            else
            {
                isEqual = false;
            }
        }
        if (isEqual == true)
        {
            Console.WriteLine("Yes, value={0}", sums[0]);
        }
        else
        {
            for (int i = 0; i < sums.Length - 1; i++)
            {
                int tempDiff = sums[i] - sums[i + 1];
                if (tempDiff > max)
                {
                    max = tempDiff;
                }
            }
            Console.WriteLine("No, maxdiff={0}", Math.Abs(max));
        }
    }
}

