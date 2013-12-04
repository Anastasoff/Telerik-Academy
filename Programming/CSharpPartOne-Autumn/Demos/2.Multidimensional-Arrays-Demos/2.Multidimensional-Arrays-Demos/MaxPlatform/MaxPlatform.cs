using System;

class MaxPlatform
{
    static void Main()
    {
        // Declare and initialize the matrix
        int[,] matrix = 
		{
			{0, 2, 4, 0, 9, 5},
			{7, 1, 3, 3, 2, 1},
			{1, 3, 9, 8, 5, 6},
			{4, 6, 7, 9, 1, 0},
		};

        // Find the maximal sum platform of size 2 x 2
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // printing the matrix WITH COLORS
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((bestRow == row && bestCol == col) || (bestRow == row && bestCol + 1 == col) || (bestRow + 1 == row && bestCol == col) || (bestRow + 1 == row && bestCol + 1 == col))
                {
                    for (int i = row; i < row + 1; i++)
                    {
                        for (int j = col; j < col + 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0}", matrix[row , col]);
                            Console.ResetColor();
                        }
                    }
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.Write(" {0}", matrix[row, col]);
                    //    Console.ResetColor();
                }
                //else if (bestRow == row && bestCol + 1 == col)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.Write(" {0}", matrix[row, col]);
                //    Console.ResetColor();
                //}
                //else if (bestRow + 1 == row && bestCol == col)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.Write(" {0}", matrix[row, col]);
                //    Console.ResetColor();
                //}
                //else if (bestRow + 1 == row && bestCol + 1 == col)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.Write(" {0}", matrix[row, col]);
                //    Console.ResetColor();
                //}
                else
                {
                    Console.Write(" {0}", matrix[row, col]);
                }

            }
            Console.WriteLine();
        }
        // Print the result
        Console.WriteLine("The best platform is:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  {0} {1}",
            matrix[bestRow, bestCol],
            matrix[bestRow, bestCol + 1]);
        Console.WriteLine("  {0} {1}",
            matrix[bestRow + 1, bestCol],
            matrix[bestRow + 1, bestCol + 1]);
        Console.ResetColor();
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}
