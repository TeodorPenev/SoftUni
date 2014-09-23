using System;

    class NumbersInIntervalDivbyGivenNumber
    {
        static void Main()
        {
            Console.Write("Please enter start number : ");
            uint start = uint.Parse(Console.ReadLine());
            Console.Write("Please enter end number : ");
            uint end = uint.Parse(Console.ReadLine());
            int count =0;

            for (uint i = start; i <=end; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            Console.WriteLine("P = {0}",count);
        }
    }

