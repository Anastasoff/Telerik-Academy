namespace MessagesInABottle
{
    public class Cipher<TKey, TValue>
    {
        public Cipher(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public TKey Key { get; set; }

        public TValue Value { get; set; }
    }
}