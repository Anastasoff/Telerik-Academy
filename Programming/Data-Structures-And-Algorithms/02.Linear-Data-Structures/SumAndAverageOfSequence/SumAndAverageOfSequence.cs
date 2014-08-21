// 1. Write a program that reads from the console a sequence of positive integer numbers.
//  The sequence ends when empty line is entered.
//  Calculate and print the sum and average of the elements of the sequence.
//  Keep the sequence in List<int>.
namespace SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;

    public class SumAndAverageOfSequence
    {
        public static IList<int> ProcessInput()
        {
            IList<int> inputSequence = new List<int>();

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

        public static int CalculateSum(IList<int> sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }

        public static int CalculateAverage(int sum, int count)
        {
            return sum / count;
        }

        public static void Main(string[] args)
        {
            IList<int> sequence = ProcessInput();

            int sum = CalculateSum(sequence);
            Console.WriteLine("Sum: " + sum);

            int average = CalculateAverage(sum, sequence.Count);
            Console.WriteLine("Average: " + average);
        }
    }
}