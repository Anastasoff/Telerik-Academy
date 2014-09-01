namespace HashTable
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private const int DefaultCapacity = 16;
        private const double DefaultLoadFactor = 0.75;
        private const double LoadFactorMinValue = 0.1;
        private const double LoadFactorMaxValue = 1.0;

        private LinkedList<KeyValuePair<TKey, TValue>>[] table;
        private IEqualityComparer<TKey> comparer;
        private double loadFactor;
        private int threshold;
        private int capacity;
        private int size;

        public HashTable(int capacity, double loadFactor, IEqualityComparer<TKey> comparer)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
            }

            if (loadFactor < LoadFactorMinValue || loadFactor > LoadFactorMaxValue)
            {
                string errorMsg = string.Format("Load factor needs to be between {0} and {1}.", LoadFactorMinValue, LoadFactorMaxValue);
                throw new ArgumentOutOfRangeException("loadFactor", errorMsg);
            }

            this.capacity = capacity;
            this.table = new LinkedList<KeyValuePair<TKey, TValue>>[this.capacity];
            this.loadFactor = loadFactor;
            this.threshold = (int)(this.capacity * this.loadFactor);
            this.comparer = comparer ?? EqualityComparer<TKey>.Default;
        }

        public HashTable(int capacity, double loadFactor)
            : this(capacity, loadFactor, null)
        {
        }

        public HashTable(int capacity)
            : this(capacity, DefaultLoadFactor, null)
        {
        }

        public HashTable(IEqualityComparer<TKey> comparer)
            : this(DefaultCapacity, DefaultLoadFactor, comparer)
        {
        }

        public HashTable()
            : this(DefaultCapacity, DefaultLoadFactor, null)
        {
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                IList<TKey> keys = new List<TKey>();
                foreach (var chain in this.table)
                {
                    if (chain != null)
                    {
                        foreach (var entry in chain)
                        {
                            keys.Add(entry.Key);
                        }
                    }
                }

                return keys;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                IList<TValue> values = new List<TValue>();
                foreach (var chain in this.table)
                {
                    if (chain != null)
                    {
                        foreach (var entry in chain)
                        {
                            values.Add(entry.Value);
                        }
                    }
                }

                return values;
            }
        }

        public IEqualityComparer<TKey> Comparer
        {
            get
            {
                return this.comparer;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return this.GetValue(key);
            }

            set
            {
                this.Insert(key, value, false);
            }
        }

        public void Add(TKey key, TValue value)
        {
            this.Insert(key, value, true);
        }

        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(key, false);
            if (chain != null)
            {
                foreach (var entry in chain)
                {
                    if (this.comparer.Equals(entry.Key, key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(key, false);
            if (chain != null)
            {
                var currentNode = chain.First;
                while (currentNode != null)
                {
                    if (this.comparer.Equals(currentNode.Value.Key, key))
                    {
                        // key found => remove the node
                        chain.Remove(currentNode);
                        this.size--;
                        return true;
                    }

                    currentNode = currentNode.Next;
                }
            }

            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(key, false);
            if (chain != null)
            {
                foreach (var entry in chain)
                {
                    if (this.comparer.Equals(entry.Key, key))
                    {
                        value = entry.Value;
                        return true;
                    }
                }
            }

            value = default(TValue);
            return false;
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            this.Insert(item.Key, item.Value, true);
        }

        public void Clear()
        {
            if (this.table != null)
            {
                this.table = new LinkedList<KeyValuePair<TKey, TValue>>[this.capacity];
            }

            this.size = 0;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (item.Key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(item.Key, false);
            if (chain != null)
            {
                foreach (var entry in chain)
                {
                    if (this.comparer.Equals(entry.Key, item.Key))
                    {
                        if (EqualityComparer<TValue>.Default.Equals(entry.Value, item.Value))
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }

            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array)
        {
            this.CopyTo(array, 0);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "array cannot be null.");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex cannot be less than zero.");
            }

            if (arrayIndex + this.size > array.Length)
            {
                throw new ArgumentException("Destination array was not long enough. Check arrayIndex and the array's length.");
            }

            int index = arrayIndex;
            foreach (var chain in this.table)
            {
                if (chain != null)
                {
                    foreach (var entry in chain)
                    {
                        array[index++] = new KeyValuePair<TKey, TValue>(entry.Key, entry.Value);
                    }
                }
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (item.Key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(item.Key, false);
            if (chain != null)
            {
                var currentNode = chain.First;
                while (currentNode != null)
                {
                    if (this.comparer.Equals(currentNode.Value.Key, item.Key))
                    {
                        if (EqualityComparer<TValue>.Default.Equals(currentNode.Value.Value, item.Value))
                        {
                            chain.Remove(currentNode);
                            this.size--;
                            return true;
                        }

                        return false;
                    }

                    currentNode = currentNode.Next;
                }
            }

            return false;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var chain in this.table)
            {
                if (chain != null)
                {
                    foreach (var entry in chain)
                    {
                        yield return entry;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<TKey, TValue>>)this).GetEnumerator();
        }

        private LinkedList<KeyValuePair<TKey, TValue>> GetChain(TKey key, bool createIfMissing)
        {
            int index = this.comparer.GetHashCode(key);

            index = index & 0x7fffffff;

            index = index % this.table.Length;
            if (this.table[index] == null && createIfMissing)
            {
                this.table[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            return this.table[index];
        }

        private TValue GetValue(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key", "key cannot be null.");
            }

            var chain = this.GetChain(key, false);
            if (chain != null)
            {
                foreach (KeyValuePair<TKey, TValue> entry in chain)
                {
                    if (this.comparer.Equals(entry.Key, key))
                    {
                        return entry.Value;
                    }
                }
            }

            throw new KeyNotFoundException("The given key was not present in the hash table.");
        }

        private void Insert(TKey key, TValue value, bool add)
        {
            var chain = this.GetChain(key, true);
            var newEntry = new KeyValuePair<TKey, TValue>(key, value);

            var currentNode = chain.First;
            while (currentNode != null)
            {
                if (this.comparer.Equals(currentNode.Value.Key, key))
                {
                    if (add)
                    {
                        throw new ArgumentException("An item with the same key has already been added.");
                    }

                    currentNode.Value = newEntry;
                    return;
                }

                currentNode = currentNode.Next;
            }

            chain.AddLast(newEntry);
            if (this.size++ >= this.threshold)
            {
                this.Resize();
            }
        }

        private void Resize()
        {
            int newCapacity = 2 * this.table.Length;
            LinkedList<KeyValuePair<TKey, TValue>>[] oldTable = this.table;
            this.table = new LinkedList<KeyValuePair<TKey, TValue>>[newCapacity];
            this.capacity = newCapacity;
            this.threshold = (int)(this.capacity * this.loadFactor);
            foreach (var oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (var entry in oldChain)
                    {
                        var chain = this.GetChain(entry.Key, true);
                        chain.AddLast(entry);
                    }
                }
            }
        }
    }
}