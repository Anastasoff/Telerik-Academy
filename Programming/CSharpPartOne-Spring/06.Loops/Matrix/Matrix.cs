// 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//     N = 3,  N = 4;

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N (N < 20): ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            for (int j = 1 + i; j <= num + i; j++)
            {
                Console.Write("{0,2} ", j);
            }
            Console.WriteLine();
        }
    }
}
