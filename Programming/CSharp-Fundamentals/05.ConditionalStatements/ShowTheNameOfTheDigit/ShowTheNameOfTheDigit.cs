﻿using System;

// 5. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
class ShowTheNameOfTheDigit
{
    static void Main()
    {
        Console.Write("Enter a digit (0-9): ");
        byte digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("You entered: Zero");
                break;
            case 1:
                Console.WriteLine("You entered: One");
                break;
            case 2:
                Console.WriteLine("You entered: Two");
                break;
            case 3:
                Console.WriteLine("You entered: Three");
                break;
            case 4:
                Console.WriteLine("You entered: Four");
                break;
            case 5:
                Console.WriteLine("You entered: Five");
                break;
            case 6:
                Console.WriteLine("You entered: Six");
                break;
            case 7:
                Console.WriteLine("You entered: Seven");
                break;
            case 8:
                Console.WriteLine("You entered: Eight");
                break;
            case 9:
                Console.WriteLine("You entered: Nine");
                break;
            default:
                Console.WriteLine("Error!");
                Console.WriteLine("Please try again!");
                break;
        }
    }
}
