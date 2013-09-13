/*
16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2004
Distance: 4 days
*/

using System;
using System.Globalization;

internal class DaysBetweenDates
{
    private static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: {0}", (secondDate - firstDate).TotalDays);
    }
}
