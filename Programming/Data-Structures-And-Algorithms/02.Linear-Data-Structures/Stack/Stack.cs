namespace Stack
{
    using System;

    internal class Stack<T>
    {
        private const int DefaultCapacity = 4;
        private T[] array;
        private int index;

        public Stack()
        {
            this.array = new T[DefaultCapacity];
            this.index = 0;
        }

        public bool IsEmpty()
        {
            return this.index == 0;
        }

        public void Push(T item)
        {
            if (this.index == this.array.Length)
            {
                this.Resize(2 * this.array.Length);
            }

            this.array[this.index++] = item;
        }

        public T Pop()
        {
            T item = this.array[--this.index];
            this.array[this.index] = default(T);
            if (this.index > 0 && this.index == (this.array.Length / 4))
            {
                this.Resize(this.array.Length / 2);
            }

            return item;
        }

        public T Peek()
        {
            if (this.IsEmpty() == true)
            {
                throw new ArgumentException("Stack is empty");
            }

            return array[index - 1];
        }

        private void Resize(int capacity)
        {
            T[] copy = new T[capacity];
            for (int i = 0; i < this.index; i++)
            {
                copy[i] = this.array[i];
            }

            this.array = copy;
        }
    }
}