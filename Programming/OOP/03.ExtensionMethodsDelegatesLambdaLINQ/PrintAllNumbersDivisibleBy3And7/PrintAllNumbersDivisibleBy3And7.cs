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
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);   
            }

            Console.WriteLine("Found with Lambda expression:\n");
            var resultWithLambda = numbers.FindAll(x => (x % 3) == 0 && (x % 7) == 0);
            foreach (var number in resultWithLambda)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("\nFound with LINQ:\n");
            var resultWithLinq =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var number in resultWithLinq)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}
