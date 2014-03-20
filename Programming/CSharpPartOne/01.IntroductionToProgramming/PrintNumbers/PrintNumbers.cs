// 4. Write a program to print the numbers 1, 101 and 1001.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("4. Write a program to print the numbers ");
        for (int i = 1, n = 1; i <= 3; i++)
        {
            if (i != n)
            {
                Console.Write(", {0}", n);
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("0");
                }
                Console.Write(n);
            }
            else
            {
                Console.Write(n);
            }
        }
        Console.WriteLine('.');
    }
}
