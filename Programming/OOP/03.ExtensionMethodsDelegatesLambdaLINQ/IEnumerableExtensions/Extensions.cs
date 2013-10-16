namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            dynamic sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            dynamic product = 1;
            foreach (var item in source)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            dynamic min = int.MaxValue;
            foreach (var item in source)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            dynamic max = int.MinValue;
            foreach (var item in source)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            dynamic sum = 0;
            decimal counter = 0;
            foreach (var item in source)
            {
                sum += item;
                counter++;
            }

            return sum / counter;
        }

        public static string ToString<T>(this IEnumerable<T> source)
        {
            StringBuilder result = new StringBuilder();

            result.Append("{ ");
            foreach (var item in source)
            {
                result.Append(item.ToString());
                result.Append(" ");
            }

            result.Append("}");
            return result.ToString();
        }
    }
}
