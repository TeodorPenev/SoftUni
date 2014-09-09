using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool[,] checkPosition = new bool[n, n];

        int col = 0;
        int row = 0;

        int right = 0;
        int down = 1;
        int left = 2;
        int up = 3;
        int direction = right;

        for (int i = 1; i <= matrix.Length; i++)
        {
            if (direction == right)
            {
                if (col < matrix.GetLength(0) && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    col++;
                }
                else
                {
                    direction = down;
                    row++;
                    col--;
                }
            }
            if (direction == down)
            {
                if (row < matrix.GetLength(1) && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    row++;
                }
                else
                {
                    direction = left;
                    col--;
                    row--;
                }
            }
            if (direction == left)
            {
                if (col >= 0 && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    col--;
                }
                else
                {
                    direction = up;
                    row--;
                    col++;
                }
            }
            if (direction == up)
            {
                if (row >= 0 && checkPosition[row, col] != true)
                {
                    matrix[row, col] = i;
                    checkPosition[row, col] = true;
                    row--;
                    if (checkPosition[row, col] == true)
                    {
                        direction = right;
                        col++;
                        row++;
                    }
                }
                else
                {
                    direction = right;
                    col++;
                    row++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 10)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                else if (matrix[i, j] >= 10 && matrix[i, j] < 100)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                else
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}