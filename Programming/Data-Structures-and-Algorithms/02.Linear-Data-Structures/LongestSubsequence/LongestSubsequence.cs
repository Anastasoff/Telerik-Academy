// 4. Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
//  Write a program to test whether the method works correctly.
namespace FindLongestSubsequence
{
    using System;
    using System.Collections.Generic;

    internal class LongestSubsequence
    {
        public static IList<T> FindLongestSubsequence<T>(IList<T> sequence) where T : IComparable<T>
        {
            var subsequence = new List<T>();

            int startIndex = 0;
            int subsequenceLength = 0;
            int length = sequence.Count - 1;
            for (int i = 0; i < length; i++)
            {
                int currentEquals = 1;
                while (i < length && (sequence[i].CompareTo(sequence[i + 1]) == 0))
                {
                    currentEquals++;
                    i++;
                }

                if (currentEquals > subsequenceLength)
                {
                    subsequenceLength = currentEquals;
                    startIndex = i - currentEquals + 1;
                }
            }

            for (int i = startIndex; i < startIndex + subsequenceLength; i++)
            {
                subsequence.Add(sequence[i]);
            }

            return subsequence;
        }

        private static void Main(string[] args)
        {
            var sequence = new List<double>() { 4.5, 5, 10, 2, 3.14, 4, 4, 5, 6, 8, 6, 6, 6, 6.1, 7, 0, 1, -2, 4, -1, -1, -1, -1, -0.1 };

            Console.WriteLine(string.Join(", ", sequence));

            var subsequence = FindLongestSubsequence(sequence);

            Console.WriteLine(string.Join(", ", subsequence));
        }
    }
}