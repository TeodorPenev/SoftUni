using System;
namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            int hight = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            string[,] matrix = new string[hight,wight];
            for (int row = 0; row < hight; row++)
            {
                for (int column = 0; column  < wight; column ++)
                {
                    matrix[row, column] = "" + (char)('a' + row) + (char)('a' + column) + (char)('a' + row);
                }
            }
            for (int row = 0; row < hight; row++)
            {
                for (int column = 0; column < wight; column++)
                {
                    Console.Write(" "+ matrix[row,column]);
                }
                Console.WriteLine();
            }


        }
    }
}
