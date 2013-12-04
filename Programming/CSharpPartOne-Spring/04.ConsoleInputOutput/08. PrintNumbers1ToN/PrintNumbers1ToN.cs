// 8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbers1ToN
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int intNum = int.Parse(Console.ReadLine());

        // first solution

        for (int counter = 1; counter <= intNum; counter++)
        {
            Console.WriteLine(counter);
        }

        //// second solution

        //int counter = 1;
        //while (counter <= intNum)
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}
    }
}
