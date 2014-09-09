namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            int length = collection.Count;
            for (int i = 0; i < length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (collection[min].CompareTo(collection[j]) > 0)
                    {
                        min = j;
                    }
                }

                Swap(collection, i, min);
            }
        }

        private void Swap(IList<T> collection, int i, int swapIndex)
        {
            T swap = collection[i];
            collection[i] = collection[swapIndex];
            collection[swapIndex] = swap;
        }
    }
}