// 2. What is the expected running time of the following C# code? Explain why.
namespace CalcCount
{
    using System;
    public class CalcCountTask
    {
        public static long CalcCount(int[,] matrix)
        {
            long count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        public static void Main()
        {
        }
    }
}