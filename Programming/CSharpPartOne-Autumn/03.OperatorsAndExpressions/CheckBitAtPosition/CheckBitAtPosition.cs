using System;

// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
// Example: v = 5; p = 1 -> false.
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("value = ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("position = ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the bit at position [{0}] (counting from 0) \n in a given integer number '{1}' has value of 1?", position, value);
        bool result = ((value >> position) & 1) == 1;
        Console.WriteLine("v = {0}; p = {1} -> {2}", value, position, result);
    }
}
