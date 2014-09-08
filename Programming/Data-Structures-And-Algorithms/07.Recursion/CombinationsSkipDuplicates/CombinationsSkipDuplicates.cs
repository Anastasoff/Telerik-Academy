// 3. Modify the previous program to skip duplicates.
namespace CombinationsSkipDuplicates
{
    using System;

    internal class CombinationsSkipDuplicates
    {
        private static void Main(string[] args)
        {
            int n = 4;
            int k = 2;
            int[] array = new int[k];
            Combinations(0, n, 1, array);
        }

        private static void Combinations(int i, int n, int start, int[] array)
        {
            if (i >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int j = start; j <= n; j++)
            {
                array[i] = j;
                Combinations(i + 1, n, j + 1, array);
            }
        }
    }
}