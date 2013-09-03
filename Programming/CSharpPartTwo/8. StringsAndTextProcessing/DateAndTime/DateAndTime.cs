// 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

internal class DateAndTime
{
    private static void Main()
    {
        try
        {
            Console.Write("Enter date and time (day.month.year hour:minute:second): ");
            DateTime input = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:mm:ss", CultureInfo.InvariantCulture);
            DateTime newDate = input.AddHours(6).AddMinutes(30);
            Console.WriteLine(newDate.ToString("dddd, d.M.yyyy H:mm:ss", new CultureInfo("bg-BG")));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format!");
            Console.WriteLine("Please try again!");
        }
    }
}
