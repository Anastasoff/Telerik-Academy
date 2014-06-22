using System;

// 12. We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101); n = 5 (00000101), p=2, v=0 -> 1 (00000001)
class ChangeBitValue
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter a value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());

        int mask = 0;
        int result = 0;
        if (value == 1)
        {
            mask = 1 << position;
            result = integer | mask;
            Console.Write("n = {0} ({1}), p = {2}, v = {3} -> ", integer, Bits(integer), position, value);
            Console.WriteLine("{0} ({1})", result, Bits(result));

        }
        else if (value == 0)
        {
            mask = ~(1 << position);
            result = integer & mask;
            Console.Write("n = {0} ({1}), p = {2}, v = {3} -> ", integer, Bits(integer), position, value);
            Console.WriteLine("{0} ({1})", result, Bits(result));
        }
        else
        {
            Console.WriteLine("\nValue must be 0 or 1.\n");
        }
    }

    static string Bits(int integer)
    {
        return Convert.ToString(integer, 2).PadLeft(8, '0');
    }
}
