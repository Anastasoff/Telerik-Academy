﻿namespace CalcSum
{
    using System;
    public class CalcSumTask
    {
        public static long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
                sum += matrix[row, col];
            if (row + 1 < matrix.GetLength(1))
                sum += CalcSum(matrix, row + 1);
            return sum;
        }

        public static void Main()
        {
            // Console.WriteLine(CalcSum(matrix, 0));
        }
    }
}