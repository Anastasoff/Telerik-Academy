/*
* 1. Write a program that counts in a given array of double
* values the number of occurrences of each value.
* Use Dictionary<TKey,TValue>.
*
* Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
* -2.5 -> 2 times
* 3 -> 4 times
* 4 -> 3 times
*/

namespace FindOccurrencesInArray
{
    using System;
    using System.Collections.Generic;

    internal class FindOccurrencesInArray
    {
        public static IDictionary<T, int> FindOccurrences<T>(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }

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

        public static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Console.WriteLine(string.Join(", ", array));

            var occurrences = FindOccurrences(array);
            foreach (var item in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}