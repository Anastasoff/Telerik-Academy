// 7. * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;

public class LargestAreaOfEqualElements
{
    private static int[,] matrix =
    {
        { 1, 3, 2, 2, 2, 4 },
        { 3, 3, 3, 2, 4, 4 },
        { 4, 3, 1, 2, 3, 3 },
        { 4, 3, 1, 3, 3, 1 },
        { 4, 3, 3, 3, 1, 1 }
    };

    private static int currentArea = 0;
    private static int maxArea = int.MinValue;
    private static List<Tuple<int, int>> visited = new List<Tuple<int, int>>();
    private static int matrixRowsLength = matrix.GetLength(0);
    private static int matrixColsLength = matrix.GetLength(1);

    public static void Check(int row, int col, int previousRow, int previousCol)
    {
        if (row == matrixRowsLength || col == matrixColsLength || row == -1 || col == -1 || visited.Contains(new Tuple<int, int>(row, col)))
        {
            return;
        }

        if (matrix[row, col] != matrix[previousRow, previousCol])
        {
            return;
        }
        else
        {
            currentArea++;
            visited.Add(new Tuple<int, int>(row, col));
            Check(row, col + 1, row, col);
            Check(row, col - 1, row, col);
            Check(row + 1, col, row, col);
            Check(row - 1, col, row, col);
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int mid = matrixRowsLength / 2;
        for (int row = 0; row < matrixRowsLength; row++)
        {
            for (int col = 0; col < matrixColsLength; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }

            if (mid == row)
            {
                Console.Write("  ----> {0}", maxArea);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        for (int row = 0; row < matrixRowsLength; row++)
        {
            for (int col = 0; col < matrixColsLength; col++)
            {
                Check(row, col, row, col);
                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }

                currentArea = 0;
            }
        }

        PrintMatrix(matrix);
    }
}