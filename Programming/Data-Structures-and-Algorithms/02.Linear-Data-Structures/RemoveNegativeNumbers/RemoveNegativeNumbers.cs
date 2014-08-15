namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    internal class RemoveNegativeNumbers
    {
        public static void FindAndRemoveNegativeNumbers<T>(LinkedList<T> sequence) where T : IComparable<T>
        {
            sequence.RemoveAll(n => n.CompareTo((T)Convert.ChangeType(0, typeof(T))) < 0);
        }

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

            FindAndRemoveNegativeNumbers(sequence);

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}