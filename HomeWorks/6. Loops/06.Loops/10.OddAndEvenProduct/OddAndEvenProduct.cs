using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        int prodOdd = 1;
        int prodEven = 1;

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
            if (i%2==0)
            {
                prodOdd = prodOdd * nums[i];
                continue;
            }
             prodEven = prodEven * nums[i];
        }

        if (prodOdd==prodEven)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}",prodOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}",prodOdd);
            Console.WriteLine("even_product = {0}", prodEven);
        }
    }
}

