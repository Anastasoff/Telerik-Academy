namespace UniversalMethod
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0}", Sum(m => 1 / (decimal)Math.Pow(2, m - 1)));
            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ... = {0}", Sum(m => 1m / Enumerable.Range(1, m).Aggregate((a, b) => a * b)));
            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ... = {0}", Sum(m => -1 / (decimal)Math.Pow(-2, m - 1)));
        }

        /// <summary>
        /// 20.* By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. 
        /// By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series.
        /// </summary>
        private static decimal Sum(Func<int, decimal> f)
        {
            decimal precision = 0.001m;
            decimal sum = 1;
            for (int i = 2; Math.Abs(f(i)) > precision; i++)
            {
                sum += f(i);
            }

            return sum;
        }
    }
}