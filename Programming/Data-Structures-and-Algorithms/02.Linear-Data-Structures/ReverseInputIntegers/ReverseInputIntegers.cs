// 2. Write a program that reads N integers from the console and reverses them using a stack.
//  Use the Stack<int> class.
namespace ReverseInputIntegers
{
    using System;
    using System.Collections.Generic;

    internal class ReverseInputIntegers
    {
        public static Stack<int> ProcessInput()
        {
            Stack<int> integers = new Stack<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == string.Empty || input == "end")
                {
                    break;
                }

                int currentInteger = int.Parse(input);
                integers.Push(currentInteger);
            }

            return integers;
        }

        private static void Main(string[] args)
        {
            Stack<int> integers = ProcessInput();

            while (integers.Count > 0)
            {
                Console.WriteLine(integers.Pop());
            }
        }
    }
}