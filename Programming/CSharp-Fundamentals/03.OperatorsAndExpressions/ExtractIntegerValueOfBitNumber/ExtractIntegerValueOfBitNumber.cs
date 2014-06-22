using System;

// 11. Write an expression that extracts from a given integer i the value of a given bit number b. 
// Example: i = 5; b = 2 -> value = 1.
class ExtractIntegerValueOfBitNumber
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Enter bit number: ");
        int bit = int.Parse(Console.ReadLine());
        int mask = 1 << bit;
        int intAndMask = integer & mask;
        int value = intAndMask >> bit;
        Console.WriteLine("i = {0}; b = {1} -> value = {2}", integer, bit, value);
    }
}
