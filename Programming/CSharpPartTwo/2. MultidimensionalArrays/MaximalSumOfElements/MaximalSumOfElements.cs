// 2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSumOfElements
{
    static void Main()
    {
        // input
        int[,] matrix = 
        {
            { 1, 2, 3, 4, 5, 6, 7, 1, 9, 5, 9, 1, 3 }, 
            { 9, 8, 7, 4, 5, 6, 1, 2, 3, 5, 1, 0, 7 }, 
            { 1, 4, 7, 8, 5, 2, 3, 6, 9, 5, 3, 1, 1 }, 
            { 3, 6, 9, 2, 5, 8, 7, 4, 8, 9, 7, 1, 3 }, 
            { 0, 1, 0, 0, 1, 1, 1, 9, 0, 9, 2, 3, 1 }
        };

        // Declare and initialize the matrix

        //Console.Write("Enter N (number of rows) = ");
        //int sizeRows = int.Parse(Console.ReadLine());
        //Console.Write("Enter M (number of cols) = ");
        //int sizeCols = int.Parse(Console.ReadLine());

        // filling matrix

        //int[,] matrix = new int[sizeRows, sizeCols];
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("matrix[{0},{1}] = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // printing the matrix with max sum in red
        Console.WriteLine(new string('-', matrix.GetLength(0) * 8));
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((bestRow == row && bestCol == col) || (bestRow == row && bestCol + 1 == col) || (bestRow == row && bestCol + 2 == col) ||
                    (bestRow + 1 == row && bestCol == col) || (bestRow + 1 == row && bestCol + 1 == col) || (bestRow + 1 == row && bestCol + 2 == col) ||
                    (bestRow + 2 == row && bestCol == col) || (bestRow + 2 == row && bestCol + 1 == col) || (bestRow + 2 == row && bestCol + 2 == col))
                {
                    for (int i = row; i < row + 1; i++)
                    {
                        for (int j = col; j < col + 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0, 3}", matrix[row, col]);
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', matrix.GetLength(0) * 8));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The maximal sum is: {0}", bestSum);
        Console.ResetColor();
    }
}
