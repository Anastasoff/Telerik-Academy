// Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.
namespace MathOperations
{
    using System;
    using System.Diagnostics;

    internal class MathOperations
    {
        public static void Main(string[] args)
        {
            SquareRoot();
            NaturalLogarithm();
            Sinus();
        }

        public static void PerformanceTest(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine("Time taken: {0}", stopwatch.Elapsed);
        }

        public static void SquareRoot()
        {
            Console.WriteLine(new string('=', 17) + "Square root" + new string('=', 17));
            Console.Write("Float =>\t");
            PerformanceTest(() => Math.Sqrt(90.0F));
            Console.Write("Double =>\t");
            PerformanceTest(() => Math.Sqrt(90.0));
            Console.Write("Decimal =>\t");
            PerformanceTest(() => Math.Sqrt((double)90.0M));
            Console.WriteLine(new string('=', 17) + "### end ###" + new string('=', 17));
            Console.WriteLine();
        }

        public static void NaturalLogarithm()
        {
            Console.WriteLine(new string('=', 14) + "Natural logarithm" + new string('=', 14));
            Console.Write("Float =>\t");
            PerformanceTest(() => Math.Log(90.0F));
            Console.Write("Double =>\t");
            PerformanceTest(() => Math.Log(90.0));
            Console.Write("Decimal =>\t");
            PerformanceTest(() => Math.Log((double)90.0M));
            Console.WriteLine(new string('=', 17) + "### end ###" + new string('=', 17));
            Console.WriteLine();
        }

        public static void Sinus()
        {
            Console.WriteLine(new string('=', 20) + "Sinus" + new string('=', 20));
            Console.Write("Float =>\t");
            PerformanceTest(() => Math.Sin(90.0F));
            Console.Write("Double =>\t");
            PerformanceTest(() => Math.Sin(90.0));
            Console.Write("Decimal =>\t");
            PerformanceTest(() => Math.Sin((double)90.0M));
            Console.WriteLine(new string('=', 17) + "### end ###" + new string('=', 17));
            Console.WriteLine();
        }
    }
}