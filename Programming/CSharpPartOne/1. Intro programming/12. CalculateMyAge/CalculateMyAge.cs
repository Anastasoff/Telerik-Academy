// 12. * Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class CalculateMyAge
{
    static void Main()
    {
        Console.Write("Write your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("After 10 years you will be: ");
        Console.WriteLine(age + 10);
    }
}
