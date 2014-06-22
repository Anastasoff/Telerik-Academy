namespace BinarySearchTree
{
    using System;

    public class TreeNode<T>
        where T : IComparable<T>
    {
        public TreeNode(T value)
        {
            this.Value = value;
            this.LeftChild = null;
            this.RightChild = null;
            this.Parent = null;
            this.Balance = 0;
        }

        public T Value { get; set; }

        public TreeNode<T> LeftChild { get; set; }

        public TreeNode<T> RightChild { get; set; }

        public TreeNode<T> Parent { get; set; }

        public int Balance { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode() ^ this.Balance << 4;
        }

        public override bool Equals(object obj)
        {
            var castedObj = obj as TreeNode<T>;

            if (castedObj == null)
            {
                return false;
            }

            return this.Value.CompareTo(castedObj.Value) == 0;
        }
    }
}