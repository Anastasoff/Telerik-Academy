// 4. Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n.
namespace Permutation
{
    using System;

    internal class Permutation
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int[] array = new int[n];
            bool[] used = new bool[n];
            Permute(array, 0, used);
        }

        private static void Permute(int[] array, int i, bool[] used)
        {
            if (i == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int j = 1; j <= array.Length; j++)
            {
                if (!used[j - 1])
                {
                    array[i] = j;
                    used[j - 1] = true;
                    Permute(array, i + 1, used);
                    used[j - 1] = false;
                }
            }
        }
    }
}