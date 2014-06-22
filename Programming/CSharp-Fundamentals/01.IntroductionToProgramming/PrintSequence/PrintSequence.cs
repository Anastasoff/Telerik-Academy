// 9. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Program
{
    static void Main()
    {
        int sequenceLength = 10;
        for (int i = 1; i <= sequenceLength; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(-i - 1);
            }
            else
            {
                Console.Write(i + 1);
            }

            // avoid comma after last digit
            if (i != sequenceLength)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
