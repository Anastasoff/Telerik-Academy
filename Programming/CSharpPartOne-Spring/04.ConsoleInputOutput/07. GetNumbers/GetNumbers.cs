// 7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

using System;

class GetNumbers
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            int counter = i + 1;
            Console.Write("Enter number {0}= ", counter);
            int input = int.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine("Sum = " + sum);
    }
}
