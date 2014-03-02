namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64()
            : this(0)
        {
        }

        public BitArray64(ulong bitArrayValue)
        {
            this.BitArrayValue = bitArrayValue;
        }

        public ulong BitArrayValue { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 64)
                {
                    throw new ArgumentOutOfRangeException("Index must be in the range [0 ... 64]");
                }

                ulong mask = (ulong)1 << index;
                if ((this.BitArrayValue & mask) == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        #region Methods

        public static bool operator ==(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return BitArray64.Equals(firstBitArray, secondBitArray);
        }

        public static bool operator !=(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return !BitArray64.Equals(firstBitArray, secondBitArray);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = (BitArray64)obj;

            if (bitArray == null)
            {
                return false;
            }

            if (!object.Equals(this.BitArrayValue, bitArray.BitArrayValue))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.BitArrayValue.GetHashCode();
        }

        public override string ToString()
        {
            return Convert.ToString((long)this.BitArrayValue, 2).PadLeft(64, '0');
        }

        #endregion
    }
}
