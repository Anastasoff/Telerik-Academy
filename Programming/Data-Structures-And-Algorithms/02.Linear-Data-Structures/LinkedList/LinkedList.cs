
namespace LinkedList
{
    using System;

    public class LinkedList<T>
    {
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }

            public Node Next { get; set; }
        }

        private Node head;
        private Node last;
        private int size;

        public LinkedList()
        {
            this.size = 0;
            this.head = null;
            this.last = null;
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
            Node newNode = new Node(value);

            if (this.size == 0)
            {
                this.head = newNode;
                this.last = newNode;
            }
            else
            {
                this.head.Next = newNode;
                this.last = newNode;
            }

            this.size++;
        }

        public void Clear()
        {
            if (this.size != 0)
            {
                this.head = null;
                this.last = null;
            }
        }

        // TODO: implement
        public Node Find(T value)
        {
            return new Node();
        }

        // TODO: implement
        public bool Remove(T value)
        {
            return true;
        }
        
        // TODO: implement
        public bool Contains(T value)
        {
            return true;
        }
    }
}
