using System;
class OddEvenElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        double[] nums = new double[input.Length];
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        bool evenExist = false;
        bool oddExist = false;
        if (input[0] == "")
        {
            input[0] = "0";
        }

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = double.Parse(input[i]);
            if ((i + 1) % 2 != 0)
            {
                oddExist = true;
                oddSum = oddSum + nums[i];
                if (nums[i] > oddMax)
                {
                    oddMax = nums[i];
                }
                if (nums[i] < oddMin)
                {
                    oddMin = nums[i];
                }
            }
            if ((i + 1) % 2 == 0)
            {
                evenExist = true;
                evenSum = evenSum + nums[i];
                if (nums[i] > evenMax)
                {
                    evenMax = nums[i];
                }
                if (nums[i] < evenMin)
                {
                    evenMin = nums[i];
                }
            }
        }
        if (oddExist == false || evenExist == false)
        {

            if (evenExist == false && input[0] == "0")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");

            }
            if (oddExist == false && input[0] != "0")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={0:0.##}, EvenMin={1:0.##}, EvenMax={2:0.##}", evenSum, evenMin, evenMax);

            }
            if (evenExist == false && input[0] != "0")
            {
                Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
            }

        }
        else if (input[0] != "0")
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}
