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

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = randomGenerator.Next(-10, 11);
                }

                Action<string> output = Console.WriteLine;
                output(string.Format("Array\t=> {0}\n", numbers.ToString<int>()));
                output(string.Format("Sum\t=>{0,10}", numbers.Sum<int>()));
                output(string.Format("Product\t=>{0,10}", numbers.Product<int>()));
                output(string.Format("Min\t=>{0,10}", numbers.Min<int>()));
                output(string.Format("Max\t=>{0,10}", numbers.Max<int>()));
                output(string.Format("Average\t=>{0,10:F2}", numbers.Average<int>()));
                output("\nPress any key to stop...");
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