/*
* 2. Write a program that extracts from a given sequence of
* strings all elements that present in it odd number of times.
*
* Example: { C#, SQL, PHP, PHP, SQL, SQL } -> { C#, SQL }
*/

namespace ExtractOddElementsInSequence
{
    using System;
    using System.Collections.Generic;

    internal class ExtractOddElementsInSequence
    {
        public static ISet<T> FindAndRemoveOddOccurNumbers<T>(IList<T> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException("array", "Sequence cannot be null.");
            }

            IDictionary<T, int> occurrences = new Dictionary<T, int>();
            ISet<T> result = new HashSet<T>();
            for (int i = 0; i < sequence.Count; i++)
            {
                T currentNumber = sequence[i];
                if (occurrences.ContainsKey(currentNumber))
                {
                    occurrences[currentNumber]++;
                }
                else
                {
                    occurrences[currentNumber] = 1;
                }
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                T currentNumber = sequence[i];
                if (occurrences.ContainsKey(currentNumber) && (occurrences[currentNumber] % 2 != 0))
                {
                    result.Add(sequence[i]);
                }
            }

            return result;
        }

        public static void Main()
        {
            string[] sequence = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Console.Write("{{ {0} }} => ", string.Join(", ", sequence));

            var oddOccurrences = FindAndRemoveOddOccurNumbers(sequence);
            Console.WriteLine("{{ {0} }}", string.Join(", ", oddOccurrences));
        }
    }
}