// 3. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class WhichDayIsToday
{
    static void PrintDay()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine(" Today is {0} ", today);

        //DateTime today = DateTime.Now;
        //Console.WriteLine("Today is {0}", today.ToString("dddd"));
        Console.ResetColor();
    }

    static void Main()
    {
        PrintDay();
    }
}
