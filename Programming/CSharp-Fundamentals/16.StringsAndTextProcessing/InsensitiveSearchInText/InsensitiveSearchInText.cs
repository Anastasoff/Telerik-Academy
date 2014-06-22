/*
4. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
      Example: 
    The target substring is "in". 
    The text is as follows:

We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9.
*/

using System;
using System.Text.RegularExpressions;

internal class InsensitiveSearchInText
{
    private static void Main()
    {
        Console.Write("Enter the target: ");
        string target = Console.ReadLine();
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        
        int targetLength = target.Length;
        int counter = 0;

        for (int i = 0; i < text.Length - targetLength + 1; i++)
        {
            if (text.ToLower().Substring(i, targetLength) == target)
            {
                counter++;
                i += targetLength - 1;
            }
        }

        // counter = Regex.Matches(text, target, RegexOptions.IgnoreCase).Count;
        Console.WriteLine("The result is: {0}", counter);
    }
}
