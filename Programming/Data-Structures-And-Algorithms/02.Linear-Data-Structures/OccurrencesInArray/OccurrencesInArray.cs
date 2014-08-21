// 7. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
namespace OccurrencesInArray
{
    using System;
    using System.Collections.Generic;

    internal class OccurrencesInArray
    {
        public static IDictionary<T, int> FindOccurrences<T>(T[] array)
        {
            var occurrences = new SortedDictionary<T, int>();

            for (int i = 0; i < array.Length; i++)
            {
                T currentValue = array[i];
                if (occurrences.ContainsKey(currentValue))
                {
                    occurrences[currentValue]++;
                }
                else
                {
                    occurrences[currentValue] = 1;
                }
            }

            return occurrences;
        }

        private static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", array));

            var occurrences = FindOccurrences(array);
            foreach (var item in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}