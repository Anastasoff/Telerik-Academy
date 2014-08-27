namespace LinkedList
{
    using System;

    public class LinkedListNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }

        public int CompareTo(T obj)
        {
            return this.Value.CompareTo(obj);
        }
    }
}