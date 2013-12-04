using System;

class BitwiseOperators
{
	static void Main()
	{
		ushort a = 3;                  // 0000 0000  0000 0011 = 3
		ushort b = 5;                  // 0000 0000  0000 0101 = 5
                                                          
		Console.WriteLine( a | b);     // 0000 0000  0000 0111 = 7
		Console.WriteLine( a & b);     // 0000 0000  0000 0001 = 1
		Console.WriteLine( a ^ b);     // 0000 0000  0000 0110 = 6
		Console.WriteLine(~a & b);     // 0000 0000  0000 0100 = 4

		Console.WriteLine( a << 1 );   // 0000 0000  0000 0110 = 6
		Console.WriteLine( a >> 1 );   // 0000 0000  0000 0001 = 1
		Console.WriteLine( a >> 2 );   // 0000 0000  0000 0000 = 0
		Console.WriteLine( a << 2 );   // 0000 0000  0000 1100 = 12

		Console.WriteLine(~a);         // 1111 1111  1111 1100 = -4 = 65532
		Console.WriteLine((ushort)~a); // 1111 1111  1111 1100 = -4 = 65532

		// Find the bit at position p in a number n
		int p = 5;
		int n = 35;               // 0000 0000  0010 0011
		int mask = 1 << p;        // 0000 0000  0010 0000
		int nAndMask = n & mask;  // 0000 0000  0010 0000
		int bit = nAndMask >> p;  // 0000 0000  0000 0001
		Console.WriteLine(bit);   // bit = 1
		Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));

		// Set the bit at position p to '0' in a number n
		p = 5;
		n = 35;                     // 00000000 00100011
		mask = ~(1 << p);           // 11111111 11011111
		int result = n & mask;      // 00000000 00000011
		Console.WriteLine(result);  // result = 3
		Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

        // Set the bit at position p to '1' in a number n
		p = 4;
		n = 35;                     // 00000000 00100011
		mask = 1 << p;              // 00000000 00010000
		result = n | mask;          // 00000000 00110011
		Console.WriteLine(result);  // result = 51
		Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
	}
}
