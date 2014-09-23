using System;
class BiggestTiple
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        long[] inputNums = new long[input.Length];
        long tripleSum = 0;
        int count = 0;
        long maxSum = long.MinValue;
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            inputNums[i] = long.Parse(input[i]);
            tripleSum = tripleSum + inputNums[i];
            count++;
            if (count == 3)
            {
                if (tripleSum > maxSum)
                {
                    maxSum = tripleSum;
                    result = "" + inputNums[i - 2] + " " + inputNums[i - 1] + " " + inputNums[i];
                }
                count = 0;
                tripleSum = 0;
            }
        }
        if (count == 2)
        {
            if (tripleSum > maxSum)
            {
                maxSum = tripleSum;
                result = "" + inputNums[inputNums.Length - 2] + " " + inputNums[inputNums.Length - 1];
            }
        }
        if (count == 1)
        {
            if (tripleSum > maxSum)
            {
                maxSum = tripleSum;
                result = "" + inputNums[inputNums.Length - 1];
            }

        }
        Console.WriteLine(result);
    }
}

