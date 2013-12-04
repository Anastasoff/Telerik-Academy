// 1. Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Insert integer: ");
        int integer = int.Parse(Console.ReadLine());
        int divider = 2;

        int result = integer % divider;

        if (result == 0)
        {
            Console.WriteLine("This integer is even.");
        }

        else
        {
            Console.WriteLine("This integer is odd."); 
        }
    }
}
