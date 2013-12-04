// 7. Create a console application that prints the current date and time.

using System;
using System.Threading;

class PrintDateAndTime
{
    static void Main()
    {
        Console.Title = "Clock";
        Console.SetWindowSize(20, 9);
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;
        Console.CursorVisible = false;        

        // use endless 'while' loop
        while (true)
        {
            Console.SetCursorPosition(6, 3);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.SetCursorPosition(4, 4);
            Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy")); // set date format
            Console.SetCursorPosition(6, 5);
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Thread.Sleep(1000); // stops while loop for 1000 milliseconds or 1 second
            Console.Clear(); // clear all text from the console
        }
    }
}
