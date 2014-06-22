// 2. Create, compile and run a "Hello C#" console application.

using System;

class HelloCSharp
{
    static void Main()
    {
        // Set window title
        Console.Title = "HelloCSharp";

        // Set window size (width, height) 
        Console.SetWindowSize(32, 7);

        // Set window buffer size same as window size
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;

        // Makes cursor invisible
        Console.CursorVisible = false;

        // Set cursor to position. 
        Console.SetCursorPosition(12, 3);

        Console.WriteLine("Hello C#!");

        // Set text color to black
        Console.ForegroundColor = ConsoleColor.Black;
    }
}
