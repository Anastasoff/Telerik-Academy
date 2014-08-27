namespace Queue
{
    public class Queue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public void Enqueue(T item)
        {
            QueueNode<T> oldTail = this.tail;
            this.tail = new QueueNode<T>();
            this.tail.Value = item;
            this.tail.Next = null;

            if (IsEmpty() == true)
            {
                this.head = this.tail;
            }
            else
            {
                oldTail.Next = this.tail;
            }
        }

        public T Dequeue()
        {
            T item = this.head.Value;
            this.head = this.head.Next;
            if (IsEmpty() == true)
            {
                this.tail = null;
            }

            return item;
        }
    }
}