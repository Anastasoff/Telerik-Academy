// 2. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static Random randomGenerator = new Random();

    static void PrintValues()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("[{0}] -> {1}", i, randomGenerator.Next(100, 201));
        }
    }

    static void Main()
    {
        PrintValues();
    }
}
