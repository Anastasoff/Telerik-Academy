namespace ImplementPriorityQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PriorityQueue<T> : IEnumerable<T>
        where T : IComparable
    {
        private IList<T> heap;

        public PriorityQueue()
        {
            this.heap = new List<T>();
        }

        public int Count
        {
            get { return this.heap.Count; }
        }

        private bool isQueueEmpty()
        {
            if (this.heap.Count <= 0)
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            this.heap.Clear();
        }

        public void Enqueue(T element)
        {
            this.heap.Add(element);
            int elementIndex = this.heap.Count - 1;
            while (elementIndex > 0)
            {
                int parentIndex = (elementIndex - 1) / 2;
                if (this.heap[parentIndex].CompareTo(this.heap[elementIndex]) <= 0)
                {
                    break;
                }

                T temp = this.heap[elementIndex];
                this.heap[elementIndex] = this.heap[parentIndex];
                this.heap[parentIndex] = temp;
                elementIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            int lastIndex = this.heap.Count - 1;
            T firstElement = this.heap[0];
            this.heap[0] = this.heap[lastIndex];
            this.heap.RemoveAt(lastIndex);
            int parentIndex = 0;
            lastIndex--;
            while (true)
            {
                int leftindex = (parentIndex * 2);
                if (leftindex > lastIndex)
                {
                    break;
                }

                int childWithPriorityIndex = leftindex;
                int rightIndex = leftindex + 1;
                if (this.Count == 1)
                {
                    return this.heap[0];
                }

                if (this.heap[rightIndex].CompareTo(this.heap[leftindex]) >= 0)
                {
                    childWithPriorityIndex = rightIndex;
                }

                if (this.heap[parentIndex].CompareTo(this.heap[childWithPriorityIndex]) >= 0)
                {
                    break;
                }

                T temp = this.heap[childWithPriorityIndex];
                this.heap[childWithPriorityIndex] = this.heap[parentIndex];
                this.heap[parentIndex] = temp;
                parentIndex = childWithPriorityIndex;
            }
            return firstElement;
        }

        public T Peek()
        {
            T element = this.heap[0];
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.heap.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in this.heap)
            {
                yield return item;
            }
        }
    }
}