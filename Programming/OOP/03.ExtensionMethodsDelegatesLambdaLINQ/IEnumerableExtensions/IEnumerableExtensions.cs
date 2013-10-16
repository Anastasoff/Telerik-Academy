// 2. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Threading;

    public class IEnumerableExtensions
    {
        public static void Main()
        {
            Random randomGenerator = new Random();
            while (true)
            {
                int arraySize = randomGenerator.Next(6, 11);
                int[] numbers = new int[arraySize];
                Console.Write("{ ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = randomGenerator.Next(-10, 11);
                    Console.Write(numbers[i]);
                    if (i != numbers.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" }");

                Console.WriteLine("Sum\t:{0,10}", numbers.Sum<int>());
                Console.WriteLine("Product\t:{0,10}", numbers.Product<int>());
                Console.WriteLine("Min\t:{0,10}", numbers.Min<int>());
                Console.WriteLine("Max\t:{0,10}", numbers.Max<int>());
                Console.WriteLine("Average\t:{0,10:F2}", numbers.Average<int>());

                Console.WriteLine("\nPress any key to stop...");
                Thread.Sleep(500);
                Console.Clear();

                if (Console.KeyAvailable)
                {
                    Environment.Exit(0);
                }
            }           
        }
    }
}
