// 7. Write a program for generating and printingall subsetsof k stringsfrom given set of strings.
namespace Subsets
{
    using System;

    internal class Subsets
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int k = 2;

            string[] set = { "test", "rock", "fun" };
            string[] answer = new string[k];

            Generate(0, n, 0, set, answer);
        }

        private static void Generate(int i, int n, int start, string[] set, string[] answer)
        {
            if (i >= answer.Length)
            {
                Console.WriteLine(string.Join(" ", answer));
                return;
            }

            for (int j = start; j < n; j++)
            {
                answer[i] = set[j];
                Generate(i + 1, n, j + 1, set, answer);
            }
        }
    }
}