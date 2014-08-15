// 7. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
namespace OccurrencesInArray
{
    using System;
    using System.Collections.Generic;

    internal class OccurrencesInArray
    {
        public static SortedDictionary<int, int> FindOccurrences(int[] array)
        {
            var occurrences = new SortedDictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int currentInteger = array[i];
                if (occurrences.ContainsKey(currentInteger))
                {
                    occurrences[currentInteger]++;
                }
                else
                {
                    occurrences[currentInteger] = 1;
                }
            }

            return occurrences;
        }

        private static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var occurrences = FindOccurrences(array);
            foreach (var item in occurrences)
            {
                Console.WriteLine(item.Key + " -> " + item.Value + " times");
            }
        }
    }
}