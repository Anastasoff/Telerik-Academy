namespace Queue
{
    public class QueueNode<T>
    {
        public T Value { get; set; }

        public QueueNode<T> Next { get; set; }
    }
}