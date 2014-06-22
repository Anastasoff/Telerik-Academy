// 18. Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

internal class ExtractEmailAddresses
{
    private static void Main()
    {
        string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b. BAJ.iVan@yahoo.co.uk";
        foreach (Match email in Regex.Matches(text, @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,6})", RegexOptions.IgnoreCase))
        {
            Console.WriteLine(email);
        }
    }
}