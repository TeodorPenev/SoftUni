using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 21)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}

