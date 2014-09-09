using System;
class MatrixOfPalindromes
{
    static void Main()
    {
        int row;
        bool rowParse = int.TryParse(Console.ReadLine(), out row);
        int col;
        bool colParse = int.TryParse(Console.ReadLine(), out col);

        if (!rowParse || !colParse || row < 1 || col < 1)
        {
            Console.WriteLine("invalid input");
            return;
        }

        string[,] polindromes = new string[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                polindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                Console.Write(polindromes[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}