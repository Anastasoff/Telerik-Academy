namespace GenericList
{
    using System;
    using System.Text;

    // 5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    public class GenericList<T>
        where T : IComparable
    {
        // 5.1 Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        private T[] elements;

        private int currentPosition;
        private int capacity;

        public GenericList(int size)
        {
            this.capacity = size;
            this.elements = new T[this.capacity];
            this.currentPosition = 0;
        }

        public int Size
        {
            get
            {
                return this.currentPosition;
            }
        }

        // 5.3 Implement methods for:
        // Adding element
        public void Add(T elementToAdd)
        {
            if (this.currentPosition == this.capacity)
            {
                this.AutoGrow();
            }

            this.elements[this.currentPosition++] = elementToAdd;
        }

        // Accessing element by index
        public T Get(int pos)
        {
            if (pos >= this.Size)
            {
                throw new IndexOutOfRangeException();
            }

            return this.elements[pos];
        }

        // Removing element by index
        public void RemoveAt(int index)
        {
            if (this.currentPosition == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                this.currentPosition--;
                for (int i = index; i < this.currentPosition; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }
            }
        }

        // Inserting element at given position
        public void InsertAt(int index, T value)
        {
            if (index >= this.capacity)
            {
                this.AutoGrow();
            }

            for (int i = this.currentPosition + 1; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = value;
            this.currentPosition++;
        }

        // Finding element by its value
        public int Find(T value)
        {
            for (int i = 0; i < this.currentPosition; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        // Clearing the list
        public void Clear()
        {
            this.currentPosition = 0;
        }

        // 7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
        //  You may need to add a generic constraints for the type T.
        public T Min()
        {
            T smallestElement = this.elements[0];

            for (int i = 1; i < this.Size; i++)
            {
                if (smallestElement.CompareTo(this.elements[i]) > 0)
                {
                    smallestElement = this.elements[i];
                }
            }

            return smallestElement;
        }

        public T Max()
        {
            T largestElement = this.elements[0];

            for (int i = 1; i < this.Size; i++)
            {
                if (largestElement.CompareTo(this.elements[i]) < 0)
                {
                    largestElement = this.elements[i];
                }
            }

            return largestElement;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.currentPosition; i++)
            {
                result.Append(this.elements[i]);
                if (i != this.currentPosition - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        // 6. Implement auto-grow functionality:
        //  when the internal array is full, create a new array of double size and move all elements to it.
        private void AutoGrow()
        {
            this.capacity *= 2;
            T[] temp = new T[this.capacity];

            for (int i = 0; i < this.elements.Length; i++)
            {
                temp[i] = this.elements[i];
            }

            this.elements = temp;
        }
    }
}