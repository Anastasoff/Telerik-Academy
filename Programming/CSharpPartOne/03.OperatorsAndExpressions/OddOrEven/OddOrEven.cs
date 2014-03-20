using System;

// 1. Write an expression that checks if given integer is odd or even.
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number & 2) == 0) // it is the same as (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
