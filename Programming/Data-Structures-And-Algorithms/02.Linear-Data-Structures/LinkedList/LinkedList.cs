namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> current;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.current = null;
            this.size = 0;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public void Add(T value)
        {
            this.size++;
            var node = new LinkedListNode<T>();
            node.Value = value;

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public void Remove(T value)
        {
            LinkedListNode<T> previousNode = null;
            LinkedListNode<T> currentNode = this.head;

            while (currentNode.CompareTo(value) != 0)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;

                if (currentNode == null)
                {
                    throw new ArgumentException("No such element in the list!");
                }

                if (previousNode.CompareTo(value) == 0)
                {
                    previousNode = previousNode.Next;
                    currentNode = currentNode.Next;
                    this.size--;
                    break;
                }
            }
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> currentNode = this.head;
            LinkedListNode<T> result = null;

            while (currentNode.CompareTo(value) != 0)
            {
                currentNode = currentNode.Next;

                if (currentNode == null)
                {
                    throw new ArgumentException("Cannot find such element in the list!");
                }

                if (currentNode.CompareTo(value) == 0)
                {
                    result = currentNode;
                }
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}