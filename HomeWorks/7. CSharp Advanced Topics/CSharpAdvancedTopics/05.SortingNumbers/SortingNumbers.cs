using System;
class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            nums[i] = temp;
        }
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}

