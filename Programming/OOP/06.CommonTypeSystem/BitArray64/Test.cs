// 5. Define a class BitArray64 to hold 64 bit values inside an ulong value. 
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;

    public class Test
    {
        public static void Main()
        {
            long firstNumber = 1234567890123456789;
            Console.WriteLine(Convert.ToString(firstNumber, 2).PadLeft(64, '0'));
            ulong secondNumber = 1234567890123456789;
            BitArray64 bitArrayOne = new BitArray64(secondNumber);            
            foreach (var bit in bitArrayOne)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine(new string('=', 64));

            BitArray64 bitArrayTwo = new BitArray64((ulong)firstNumber);
            Console.WriteLine("Is bitArrayOne equals bitArrayTwo ? ==> {0}", bitArrayOne.Equals(bitArrayTwo));
            Console.WriteLine("Is bitArrayOne == bitArrayTwo ? ==> {0}", bitArrayOne == bitArrayTwo);
            Console.WriteLine("Is bitArrayOne != bitArrayTwo ? ==> {0}", bitArrayOne != bitArrayTwo);

            Console.WriteLine(new string('=', 64));
            
            Console.WriteLine(bitArrayOne.ToString());
        }
    }
}
