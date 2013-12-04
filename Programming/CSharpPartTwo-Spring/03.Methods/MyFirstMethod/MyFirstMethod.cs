// 1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Linq;

class MyFirstMethod
{
    // check if the first letter is capital
    static bool IsCapital(string name)
    {
        bool isCapital = char.IsLower(name.First());
        return isCapital;
    }

    // check if the string is filled only with letters
    static bool ValidateName(string name)
    {
        bool result = false;
        for (int i = 0; i < name.Length; i++)
        {
            result = char.IsLetter(name, i);
        }

        return result;
    }

    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string yourName = Console.ReadLine();

        if (IsCapital(yourName))
        {
            Console.WriteLine("Try again with CAPITAL letter!");
        }
        else if (ValidateName(yourName))
        {
            PrintName(yourName);
        }
        else
        {
            Console.WriteLine("Incorrect input data!");
            Console.WriteLine("Please try again!");
        }        
    }
}
