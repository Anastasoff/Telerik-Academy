using System;

// 3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
class MinAndMaxValueOfSecuence
{
    static void Main()
    {
        Console.Write("Enter the length of the sequence: ");
        int length = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < minNumber)
            {
                minNumber = number;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine("Min: {0}", minNumber);
        Console.WriteLine("Max: {0}", maxNumber);
    }
}
