using System;

// 5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
class FindThirdBit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a position [0...31]: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = number & mask; // 0 & 1 = 0; 1 & 1 = 1;
        int bit = numberAndMask >> position;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.SetCursorPosition(31 - position, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(bit);
        Console.ResetColor();
    }
}
