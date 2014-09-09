namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }
            collection.Shuffle();
            this.QuickSort(collection);
        }

        private void QuickSort(IList<T> collection)
        {
            this.Partition(collection, 0, collection.Count - 1);
        }

        private void Partition(IList<T> collection, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int leftPointer = leftIndex;
            int rightPointer = rightIndex;
            T pivot = collection[(leftIndex + rightIndex) / 2];

            while (leftPointer <= rightPointer)
            {
                while (collection[leftPointer].CompareTo(pivot) < 0)
                {
                    leftPointer++;
                }

                while (collection[rightPointer].CompareTo(pivot) > 0)
                {
                    rightPointer--;
                }

                if (leftPointer <= rightPointer)
                {
                    Swap(collection, leftPointer, rightPointer);
                    leftPointer++;
                    rightPointer--;
                }
            }

            if (leftPointer < rightIndex)
            {
                Partition(collection, leftPointer, rightIndex);
            }

            if (leftIndex < rightPointer)
            {
                Partition(collection, leftIndex, rightPointer);
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