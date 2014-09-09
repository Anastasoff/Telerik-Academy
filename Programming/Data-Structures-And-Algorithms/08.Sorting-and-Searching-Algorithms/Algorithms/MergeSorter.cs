namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private T[] auxArr;

        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            this.auxArr = new T[collection.Count];
            this.Partition(collection, 0, collection.Count - 1);
        }

        private void Partition(IList<T> collection, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int middleIndex = leftIndex + ((rightIndex - leftIndex) / 2);
            this.Partition(collection, leftIndex, middleIndex);
            this.Partition(collection, middleIndex + 1, rightIndex);
            this.Merge(collection, leftIndex, middleIndex, rightIndex);
        }

        private void Merge(IList<T> collection, int leftIndex, int middleIndex, int rightIndex)
        {
            int tempPointer = leftIndex;
            int leftPointer = leftIndex;
            int rightPointer = middleIndex + 1;

            while (leftPointer <= middleIndex && rightPointer <= rightIndex)
            {
                if (collection[leftPointer].CompareTo(collection[rightPointer]) < 0)
                {
                    auxArr[tempPointer++] = collection[leftPointer++];
                }
                else
                {
                    auxArr[tempPointer++] = collection[rightPointer++];
                }
            }

            while (leftPointer <= middleIndex)
            {
                auxArr[tempPointer++] = collection[leftPointer++];
            }

            while (rightPointer <= rightIndex)
            {
                auxArr[tempPointer++] = collection[rightPointer++];
            }

            for (int index = leftIndex; index <= rightIndex; index++)
            {
                collection[index] = auxArr[index];
            }
        }
    }
}