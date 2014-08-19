/*
We are given the following sequence:
S1 = N;
S2 = S1 + 1;
S3 = 2*S1 + 1;
S4 = S1 + 2;
S5 = S2 + 1;
S6 = 2*S2 + 1;
S7 = S2 + 2;
...
Using the Queue<T> class write a program to print its first 50 members for given N.
Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/
namespace FancySequence
{
    using System;
    using System.Collections.Generic;

    internal class FancySequence
    {
        public static IList<int> CalculateSequence(int n, int membersCount)
        {
            IList<int> result = new List<int>();
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(n);
            for (int i = 0; i <= membersCount; i++)
            {
                int currentNumber = numbers.Dequeue();
                result.Add(currentNumber);

                int firstMember = currentNumber + 1;
                numbers.Enqueue(firstMember);

                int secondMember = 2 * currentNumber + 1;
                numbers.Enqueue(secondMember);

                int thirdMember = currentNumber + 2;
                numbers.Enqueue(thirdMember);
            }

            return result;
        }

        private static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Members count: ");
            int membersCount = int.Parse(Console.ReadLine());

            var result = CalculateSequence(n, membersCount);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}