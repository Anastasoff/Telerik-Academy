// 6. Write a program that removes from given sequence all numbers that occur odd number of times.
namespace RemoveOddOccurNumbers
{
    using System;
    using System.Collections.Generic;

    internal class RemoveOddOccurNumbers
    {
        public static List<int> FindAndRemoveOddOccurNumbers(List<int> sequence)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            List<int> result = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentNumber = sequence[i];
                if (numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber]++;
                }
                else
                {
                    numbers[currentNumber] = 1;
                }
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentNumber = sequence[i];
                if (numbers.ContainsKey(currentNumber) && numbers[currentNumber] % 2 == 0)
                {
                    result.Add(sequence[i]);
                }
            }

            return result;
        }

        private static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Console.WriteLine(string.Join(", ", sequence));

            List<int> result = FindAndRemoveOddOccurNumbers(sequence);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}