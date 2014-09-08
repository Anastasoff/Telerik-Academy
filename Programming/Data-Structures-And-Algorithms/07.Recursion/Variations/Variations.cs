// 5. Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
namespace Variations
{
    using System;

    internal class Variations
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            string[] set = { "hi", "a", "b" };
            string[] answer = new string[k];
            Variate(0, n, set, answer);
        }

        private static void Variate(int i, int n, string[] set, string[] answer)
        {
            if (i >= answer.Length)
            {
                Console.WriteLine(string.Join(" ", answer));
                return;
            }

            for (int j = 0; j < n; j++)
            {
                answer[i] = set[j];
                Variate(i + 1, n, set, answer);
            }
        }
    }
}