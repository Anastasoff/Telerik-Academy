namespace TreeOperations
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; private set; }

        public bool HasParent { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
        }

        public void AddChild(Node<T> child)
        {
            child.HasParent = true;
            this.Children.Add(child);
        }

        public Node<T> GetChild(int index)
        {
            return this.Children[index];
        }
    }
}