namespace UsingOrderedBag
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Wintellect.PowerCollections;

    internal class UsingOrderedBag
    {
        private static void Main()
        {
            Stopwatch watch = new Stopwatch();

            OrderedBag<Product> bag = new OrderedBag<Product>();
            watch.Start();
            AddElements(bag, 500000);
            watch.Stop();
            Console.WriteLine("Time for adding 500 000 elements in OrderedBag: {0}", watch.Elapsed);
            //search for elements

            watch.Reset();

            List<Product> elementsInRange = new List<Product>();
            watch.Restart();
            for (int i = 1; i <= 10000; i++)
            {
                decimal minPrice = i * 2;
                decimal maxPrice = i * 5;
                Product min = new Product(i.ToString(), minPrice);
                Product max = new Product(i.ToString(), maxPrice);
                elementsInRange.AddRange(bag.Range(min, true, max, true));
            }

            watch.Stop();
            Console.WriteLine("Elapsed time for 10 000 price range searches: {0}", watch.Elapsed);
        }

        private static void AddElements(OrderedBag<Product> bag, int numberOfElements)
        {
            Random generator = new Random();
            for (int i = 0; i < numberOfElements; i++)
            {
                decimal price = generator.Next(1, 1000000);
                bag.Add(new Product(i.ToString(), price));
            }
        }
    }
}