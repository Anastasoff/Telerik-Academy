// 2. Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set.
namespace CombinationsWithDuplicates
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            int[] array = new int[k];
            Combinate(0, n, 1, array);
        }

        private static void Combinate(int i, int n, int start, int[] array)
        {
            if (i >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int j = start; j <= n; j++)
            {
                array[i] = j;
                Combinate(i + 1, n, start, array);
            }
        }
    }
}