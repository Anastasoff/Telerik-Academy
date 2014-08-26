//* 10. We are given numbers N and M and the following operations:
//  N = N+1
//  N = N+2
//  N = N*2
//  Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
//  Example: N = 5, M = 16
//  Sequence: 5 -> 7 -> 8 -> 16
namespace FindTheShortestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class FindTheShortestSequence
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M = ");
            int m = int.Parse(Console.ReadLine());

            IList<int> sequence = FindSequence(n, m);
            Console.WriteLine(string.Join(" -> ", sequence));
        }

        public static IList<int> FindSequence(int n, int m)
        {
            Stack<int> sequence = new Stack<int>();

            sequence.Push(m);
            while (m / 2 >= n)
            {
                m /= 2;
                sequence.Push(m);
            }

            while (m - 2 >= n)
            {
                m -= 2;
                sequence.Push(m);
            }

            while (m - 1 >= n)
            {
                m -= 1;
                sequence.Push(m);
            }

            return sequence.ToList();
        }
    }
}