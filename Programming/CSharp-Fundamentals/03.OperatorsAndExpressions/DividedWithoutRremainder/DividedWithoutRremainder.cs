using System;

// 2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
class DividedWithoutRremainder
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 35 == 0) // 5 * 7 = 35
        {
            Console.WriteLine("Divided without remainder!");
        }
        else
        {
            Console.WriteLine("Reminder = {0}", number % 35);
        }
    }
}
