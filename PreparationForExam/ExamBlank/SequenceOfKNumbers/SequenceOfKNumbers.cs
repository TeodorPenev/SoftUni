using System;
class SequenceOfKNumbers
{
    static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');
        int k = int.Parse(Console.ReadLine());
        int count = 1;
        string after = "";

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] == sequence[i + 1])
            {
                count++;
            }
            else
            {
                if (count % k == 0)
                {
                    count = 1;
                    continue;
                }
                else
                {
                    for (int j = 0; j < count % k; j++)
                    {
                        after = after + sequence[i];

                    }
                    count = 1;
                }
            }
            
        }
        if (count %k !=0)
        {
            for (int i = 0; i < count%k; i++)
            {
                after = after + sequence[sequence.Length-1];
            }
        }
        Console.WriteLine(after);

        //string[] sequence = Console.ReadLine().Split(' ');
        //int k = int.Parse(Console.ReadLine());
        //string survive = "";
        //int twins = 1;

        //for (int i = 0; i < sequence.Length - 1; i++)
        //{
        //    if (sequence[i] != sequence[i + 1] && (k != twins))
        //    {
        //        survive = "" + survive + sequence[i] + " ";
        //        for (int j = 1; twins - j > 0; j++)
        //        {
        //            survive = "" + survive + sequence[i - j] + " ";

        //        }
        //        twins = 1;
        //    }
        //    else
        //    {
        //        if (k == twins)
        //        {
        //            twins = 1;
        //        }
        //        else
        //        {
        //            twins++;
        //        }

        //    }
        //}
        //if (k > twins)
        //{
        //    for (int f = 0; f < twins; f++)
        //    {
        //        survive = "" + survive + sequence[sequence.Length - 1] + " ";
        //    }
        //}
        //Console.WriteLine(survive);
    }
}
