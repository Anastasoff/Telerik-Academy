// 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

internal class ExtractDates
{
    private static void Main()
    {
        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        foreach (Match match in Regex.Matches(text, @"[\d]{1,2}\.[\d]{1,2}\.[\d]{4}", RegexOptions.IgnoreCase))
        {
            DateTime date = DateTime.ParseExact(match.ToString(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString("d.M.yyyy", new CultureInfo("en-CA")));
        }
    }
}
