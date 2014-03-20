using System;

// 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following: N = 3 N = 4
class Matrix
{
    static void Main()
    {
        Console.Write("Enter N (N < 20): ");
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)
        {
            for (int col = 1 + row; col <= number + row; col++)
            {
                Console.Write("{0,2} ", col);
            }

            Console.WriteLine();
        }
    }
}
