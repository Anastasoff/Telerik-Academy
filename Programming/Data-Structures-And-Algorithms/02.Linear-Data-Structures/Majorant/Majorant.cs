// 8. * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program to find the majorant of given array (if exists).
namespace Majorant
{
    using System;
    using System.Collections.Generic;

    internal class Majorant
    {
        // TODO: generic method
        public static int FindMajorant(IDictionary<int, int> occurrences, int count)
        {
            int majorant = 0;
            int majorantMedian = count / 2 + 1;
            foreach (var item in occurrences)
            {
                int currentValue = 0;
                if (item.Value >= majorantMedian)
                {
                    currentValue = item.Value;
                }

                if (majorant < currentValue)
                {
                    majorant = item.Key;
                }
            }

            return majorant;
        }

        public static IDictionary<T, int> FindOccurrences<T>(T[] array)
        {
            var occurrences = new Dictionary<T, int>();

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
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Console.WriteLine(string.Join(", ", array));

            var occurrences = FindOccurrences(array);
            int majorant = FindMajorant(occurrences, array.Length);
            Console.WriteLine("Majorant: " + majorant);
        }
    }
}