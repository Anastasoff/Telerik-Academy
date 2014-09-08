// 1. Write a recursive program that simulates the execution of n nested loops from 1 to n.
namespace NestedLoops
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int[] array = new int[n];
            Loop(0, array);
        }

        private static void Loop(int i, int[] array)
        {
            if (i >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int j = 1; j <= array.Length; j++)
            {
                array[i] = j;
                Loop(i + 1, array);
            }
        }
    }
}