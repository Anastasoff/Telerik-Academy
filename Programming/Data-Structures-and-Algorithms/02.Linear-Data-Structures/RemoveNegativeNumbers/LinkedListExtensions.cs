namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public static class LinkedListExtensions
    {
        public static void RemoveAll<T>(this LinkedList<T> list, Func<T, bool> predicate)
        {
            LinkedListNode<T> currentNode = list.First;
            while (currentNode != null)
            {
                if (predicate(currentNode.Value))
                {
                    LinkedListNode<T> toRemove = currentNode;
                    currentNode = currentNode.Next;
                    list.Remove(toRemove);
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}