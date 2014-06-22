﻿// 6. You are given a sequence of positive integer values written into a string, separated by spaces. 
//      Write a function that reads these values from given string and calculates their sum.
//      Example: string = "43 68 9 23 318" -> result = 461

using System;

class Program
{
    static void Main()
    {
        Console.Write("string =  ");
        string[] sequence = Console.ReadLine().Split(' ');

        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += int.Parse(sequence[i]);
        }

        Console.WriteLine("result = {0}", sum);
    }
}
