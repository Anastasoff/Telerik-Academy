namespace CalcSum
{
    using System;

    public class CalcSumTask
    {
        public static long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[row, col];
            }

            if (row + 1 < matrix.GetLength(1))
            {
                sum += CalcSum(matrix, row + 1);
            }

            return sum;
        }

        public static int[,] GenerateRandomMatrix(int n, int m)
        {
            Random randomGenerator = new Random();
            int[,] generatedMatrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    int currentCellValue = randomGenerator.Next(n * m * 2);
                    generatedMatrix[row, col] = currentCellValue;
                }
            }

            return generatedMatrix;
        }

        public static void Main()
        {
            int n = 10;
            int m = 5;
            int[,] matrix = GenerateRandomMatrix(n, m);
            Console.WriteLine(CalcSum(matrix, 0));
        }
    }
}