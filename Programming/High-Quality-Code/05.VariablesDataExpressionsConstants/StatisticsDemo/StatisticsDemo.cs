namespace StatisticsDemo
{
    using System;

    using Statistics;

    public class StatisticsDemo
    {
        public static void Main()
        {
            double[] arrayOfnumbers = new double[] { 0.43, 1.344, -4.23, -432.43, 4234.432, 42, 0, 1 };

            Console.WriteLine(Stats.Min(arrayOfnumbers));
            Console.WriteLine(Stats.Max(arrayOfnumbers));
            Console.WriteLine(Stats.Average(arrayOfnumbers));
        }
    }
}