using System;

// 8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
class PrintNumbers1ToN 
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
