using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem2
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split(' ');
        int[] nums = new int[S.Length];
        int J = int.Parse(Console.ReadLine());
        int sum = 0;
        int countJ = 0;
        int countK = 0;
        int index = 0;
        for (int i = 0; i < S.Length; i++)
        {
            nums[i] =int.Parse(S[i]);
        }

        for (int indexToJump = 0,k=0; indexToJump < nums.Length; indexToJump++)
        {


            for (; k < nums.Length; k++) //count 
            {
                sum = sum + nums[indexToJump];
                indexToJump =(nums[k] + k) % nums.Length;
                countJ++;
                index++;
                if (countJ == J)
                {
                    k = 0;
                    countK++;
                    k = countK;
                    break;
                }
            }
            sum = sum + nums[indexToJump];
            sum = 0;
            countJ = 0;
            index=0;
        }
    
    }
}

