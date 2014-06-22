// 6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//      Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace PrintAllNumbersDivisibleBy3And7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrintAllNumbersDivisibleBy3And7
    {
        public static void Main()
        {
            int arraySize = 100;
            int[] numbers = GetArray(arraySize, 0, 200);

            Console.WriteLine("Found with Lambda expression:\n");
            var resultWithLambda = Array.FindAll(numbers, x => (x % 3) == 0 && (x % 7) == 0);
            PrintArray(resultWithLambda);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("\nFound with LINQ query:\n");
            var resultWithLinq =
                from number in numbers
                where (number % 3) == 0 && (number % 7) == 0
                select number;
            PrintArray(resultWithLinq);
        }

        private static int[] GetArray(int size, int lower, int upper)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(lower, upper + 1);
            }

            return array;
        }

        private static void PrintArray<T>(IEnumerable<T> value)
        {
            foreach (var number in value)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}