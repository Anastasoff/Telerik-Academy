// 5. Write a program that removes from given sequence all negative numbers.
namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    internal class RemoveNegativeNumbers
    {
        private static void Main(string[] args)
        {
            var sequence = new LinkedList<int>();

            Random randomNumber = new Random();
            int length = randomNumber.Next(20, 30);
            for (int i = 0; i < length; i++)
            {
                int currentNumber = randomNumber.Next(-100, 100);
                sequence.AddLast(currentNumber);
            }

            Console.WriteLine(string.Join(", ", sequence));

            sequence.RemoveAll(x => x < 0);

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}