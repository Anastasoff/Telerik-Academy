// 2. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//      If an invalid number or non-number text is entered, the method should throw an exception. 
//      Using this method write a program that enters 10 numbers:
//      a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumbers
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (!(start < number && number < end))
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number (1, 100): ");

        try
        {
            int start = 1;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number {0} < ", start);
                start = ReadNumber(start, end);
            }
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
    }
}
