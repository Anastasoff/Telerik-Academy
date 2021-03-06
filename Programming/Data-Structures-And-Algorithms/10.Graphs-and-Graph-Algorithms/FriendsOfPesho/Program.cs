﻿namespace FriendsOfPesho
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Program
    {
        private const int MaxVertices = 10000;

        private static int n;
        private static int m;
        private static int h;
        private static List<int> hospitals;
        private static List<List<Node>> vertices;
        private static int[] distances;
        private static bool[] visited;

        public static void Main()
        {
            ProcessInput();

            distances = new int[MaxVertices];
            visited = new bool[MaxVertices];

            int minDistance = int.MaxValue;
            for (int i = 0; i < h; i++)
            {
                int currentDistance = Dijkstra(hospitals[i]);
                if (minDistance > currentDistance)
                {
                    minDistance = currentDistance;
                }
            }

            Console.WriteLine(minDistance);
        }

        private static void ProcessInput()
        {
            string[] firstRow = Console.ReadLine().Split(' ');
            n = int.Parse(firstRow[0]);
            m = int.Parse(firstRow[1]);
            h = int.Parse(firstRow[2]);

            string[] secondRow = Console.ReadLine().Split(' ');
            hospitals = new List<int>();
            for (int i = 0; i < h; i++)
            {
                hospitals.Add(int.Parse(secondRow[i]) - 1);
            }

            vertices = new List<List<Node>>(n);
            for (int i = 0; i < n; i++)
            {
                vertices.Add(null);
            }

            for (int i = 0; i < m; i++)
            {
                string[] street = Console.ReadLine().Split(' ');
                int f = int.Parse(street[0]);
                int s = int.Parse(street[1]);
                int d = int.Parse(street[2]);

                AddConnection(f - 1, s - 1, d);
                AddConnection(s - 1, f - 1, d);
            }
        }

        private static void AddConnection(int fromNode, int toNode, int distance)
        {
            Node node = new Node(toNode, distance);

            if (vertices[fromNode] == null)
            {
                vertices[fromNode] = new List<Node>();
            }

            vertices[fromNode].Add(node);
        }

        private static int Dijkstra(int source)
        {
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue;
            }

            distances[source] = 0;
            PriorityQueue<Node> queue = new PriorityQueue<Node>();
            Node node = new Node(source, 0);
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                visited[currentNode.Vertex] = true;

                if (currentNode.Distance == int.MinValue)
                {
                    break;
                }

                foreach (var neighbor in vertices[currentNode.Vertex])
                {
                    var potDistance = currentNode.Distance + neighbor.Distance;
                    if (potDistance < distances[neighbor.Vertex])
                    {
                        distances[neighbor.Vertex] = potDistance;
                        queue.Enqueue(new Node(neighbor.Vertex, potDistance));
                    }
                }
            }

            int currentDistance = 0;
            for (int i = 0; i < h; i++)
            {
                distances[hospitals[i]] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                currentDistance += distances[i];
            }
            return currentDistance;
        }
    }

    public class Node : IComparable<Node>
    {
        public Node(int vertex, int distance)
        {
            this.Vertex = vertex;
            this.Distance = distance;
        }

        public int Vertex { get; set; }

        public int Distance { get; set; }

        public int CompareTo(Node other)
        {
            return this.Distance.CompareTo(other.Distance);
        }
    }

    /// <summary>
    /// Based on the article "Priority Queues with C#" by James McCaffrey:
    /// http://visualstudiomagazine.com/articles/2012/11/01/priority-queues-with-c.aspx
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        #region Private Fields

        private List<T> data;

        #endregion Private Fields

        #region Constructors

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        #endregion Constructors

        #region Properties

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.data.Count == 0;
            }
        }

        #endregion Properties

        #region Public Methods

        public void Enqueue(T item)
        {
            // add the new item as the last element of the list
            this.data.Add(item);
            // place the child index at the end of the list
            int childIndex = this.data.Count - 1;
            while (childIndex > 0)
            {
                // find the parent index: if [n] is the parent index,
                // then its children are at positions [2n+1] and [2n+2].
                int parentIndex = (childIndex - 1) / 2;
                if (this.data[childIndex].CompareTo(this.data[parentIndex]) >= 0)
                {
                    // Lower-priority numeric values mean higher priority, so when
                    // child priority value is greater than or equal to the parent priority,
                    // then the method is done. Otherwise, the child node bubbles up until
                    // it's in the correct position.
                    break;
                }
                // child priority value is still less than the parent priority
                // => swap the values
                T tmp = this.data[childIndex];
                this.data[childIndex] = this.data[parentIndex];
                this.data[parentIndex] = tmp;
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Queue empty.");
            }
            int lastIndex = this.data.Count - 1;
            // The front item is removed by making a copy of it,
            // then overwriting the item at location [0] with
            // the item in the last location.
            T frontItem = this.data[0];
            this.data[0] = this.data[lastIndex];
            this.data.RemoveAt(lastIndex);
            // update last index
            --lastIndex;
            // Now that the last item is placed first
            // (occupying the place of the front item that was just removed),
            // it starts "trickling down" the binary heap until it finds its correct place.
            int parentIndex = 0;
            while (true)
            {
                int leftChildIndex = parentIndex * 2 + 1;
                if (leftChildIndex > lastIndex)
                {
                    break;
                }
                int rightChildIndex = leftChildIndex + 1;
                // Keeps the index of the child with lower
                // priority value, i.e. the child which is
                // eligible for the swap (if the swap takes place).
                int swapIndex = leftChildIndex;
                if (rightChildIndex <= lastIndex &&
                this.data[rightChildIndex].CompareTo(this.data[leftChildIndex]) < 0)
                {
                    // the right child is the smaller of the two children
                    swapIndex = rightChildIndex;
                }
                if (this.data[parentIndex].CompareTo(this.data[swapIndex]) <= 0)
                {
                    // the parent and the child are in order
                    break;
                }
                // the parent and the child are out of order => swap
                T tmp = this.data[parentIndex];
                this.data[parentIndex] = this.data[swapIndex];
                this.data[swapIndex] = tmp;
                parentIndex = swapIndex;
            }
            return frontItem;
        }

        public T Peek()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Queue empty.");
            }
            T frontItem = this.data[0];
            return frontItem;
        }

        public void Clear()
        {
            this.data.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T[] ToArray()
        {
            return this.data.ToArray();
        }

        public override string ToString()
        {
            return string.Join(", ", this.data);
        }

        /// <summary>
        /// Used in the unit tests.
        /// </summary>
        /// <returns></returns>
        public bool IsConsistent()
        {
            if (this.data.Count == 0)
            {
                return true;
            }
            int lastIndex = data.Count - 1;
            for (int parentIndex = 0; parentIndex < data.Count; ++parentIndex)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                int rightChildIndex = 2 * parentIndex + 2;
                if (leftChildIndex <= lastIndex &&
                data[parentIndex].CompareTo(data[leftChildIndex]) > 0)
                {
                    return false;
                }
                if (rightChildIndex <= lastIndex &&
                data[parentIndex].CompareTo(data[rightChildIndex]) > 0)
                {
                    return false;
                }
            }
            // passed all checks
            return true;
        }

        #endregion Public Methods
    }
}