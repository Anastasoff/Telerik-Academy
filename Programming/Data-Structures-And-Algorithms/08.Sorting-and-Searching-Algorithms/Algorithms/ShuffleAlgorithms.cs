namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public static class ShuffleAlgorithms
    {
        /// <summary>
        /// Fisher–Yates shuffle
        /// </summary>
        public static void Shuffle<T>(this IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            for (int i = collection.Count; i > 1; i--)
            {
                int j = RandomGenerator.GetInstance.Next(i);
                Swap<T>(collection, j, i);
            }
        }

        private static void Swap<T>(IList<T> collection, int j, int i)
        {
            T swap = collection[j];
            collection[j] = collection[i - 1];
            collection[i - 1] = swap;
        }
    }
}