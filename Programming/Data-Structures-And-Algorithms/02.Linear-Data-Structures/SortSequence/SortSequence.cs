// 3. Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
namespace SortSequence
{
    using System;
    using System.Collections.Generic;

    internal class SortSequence
    {
        public static List<int> ProcessInput()
        {
            List<int> inputSequence = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == string.Empty || input == "end")
                {
                    break;
                }

                int currentInteger = int.Parse(input);
                inputSequence.Add(currentInteger);
            }

            return inputSequence;
        }

        private static void Main(string[] args)
        {
            List<int> sequence = ProcessInput();

            sequence.Sort();

            for (int i = 0; i < sequence.Count; i++)
            {
                Console.WriteLine(sequence[i]);
            }
        }
    }
}