// 2. Write a program to compare the performance of add, subtract, increment, multiply, divide for int, long, float, double and decimal values.
namespace ArithmeticPerformance
{
    using System;
    using System.Diagnostics;

    internal class ArithmeticOperations
    {
        private const int Loops = 100000;

        public static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 15) + "Add" + new string('=', 15));
            PerformanceTest(() => Add<int>(2, "int"));
            PerformanceTest(() => Add<long>(2L, "long"));
            PerformanceTest(() => Add<float>(2.0F, "float"));
            PerformanceTest(() => Add<double>(2.0, "double"));
            PerformanceTest(() => Add<decimal>(2.0M, "decimal"));

            Console.WriteLine(new string('=', 15) + "Increment" + new string('=', 15));
            PerformanceTest(() => Increment<int>("int"));
            PerformanceTest(() => Increment<long>("long"));
            PerformanceTest(() => Increment<float>("float"));
            PerformanceTest(() => Increment<double>("double"));
            PerformanceTest(() => Increment<decimal>("decimal"));

            Console.WriteLine(new string('=', 15) + "Subtract" + new string('=', 15));
            PerformanceTest(() => Subtract<int>(2, "int"));
            PerformanceTest(() => Subtract<long>(2L, "long"));
            PerformanceTest(() => Subtract<float>(2.0F, "float"));
            PerformanceTest(() => Subtract<double>(2.0, "double"));
            PerformanceTest(() => Subtract<decimal>(2.0M, "decimal"));

            Console.WriteLine(new string('=', 15) + "Multiply" + new string('=', 15));
            PerformanceTest(() => Multiply<int>(1, "int"));
            PerformanceTest(() => Multiply<long>(1L, "long"));
            PerformanceTest(() => Multiply<float>(1.0F, "float"));
            PerformanceTest(() => Multiply<double>(1.0, "double"));
            PerformanceTest(() => Multiply<decimal>(1.0M, "decimal"));

            Console.WriteLine(new string('=', 15) + "Divide" + new string('=', 15));
            PerformanceTest(() => Divide<int>(1, "int"));
            PerformanceTest(() => Divide<long>(1L, "long"));
            PerformanceTest(() => Divide<float>(1.0F, "float"));
            PerformanceTest(() => Divide<double>(1.0, "double"));
            PerformanceTest(() => Divide<decimal>(1.0M, "decimal"));
        }

        public static void PerformanceTest(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine("Time taken: {0} \n", stopwatch.Elapsed);
        }

        public static void Add<T>(T value, string typeName) where T : IComparable<T>
        {
            dynamic result = default(T);
            for (int i = 0; i < Loops; i++)
            {
                result += value;
            }

            Console.WriteLine("{0} result = {1}", typeName, result);
        }

        public static void Increment<T>(string typeName) where T : IComparable<T>
        {
            dynamic result = default(T);
            for (int i = 0; i < Loops; i++)
            {
                result++;
            }

            Console.WriteLine("{0} result = {1}", typeName, result);
        }

        public static void Subtract<T>(T value, string typeName) where T : IComparable<T>
        {
            dynamic result = default(T);
            for (int i = 0; i < Loops; i++)
            {
                result -= value;
            }

            Console.WriteLine("{0} result = {1}", typeName, result);
        }

        public static void Multiply<T>(T value, string typeName) where T : IComparable<T>
        {
            dynamic result = default(T);
            result++;
            for (int i = 0; i < Loops; i++)
            {
                result *= value;
            }

            Console.WriteLine("{0} result = {1}", typeName, result);
        }

        public static void Divide<T>(T value, string typeName) where T : IComparable<T>
        {
            dynamic result = default(T);
            result++;
            for (int i = 0; i < Loops; i++)
            {
                result /= value;
            }

            Console.WriteLine("{0} result = {1}", typeName, result);
        }
    }
}