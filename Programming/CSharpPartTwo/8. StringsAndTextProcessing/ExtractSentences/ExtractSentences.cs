﻿/*
8. Write a program that extracts from a given text all sentences containing given word.
* Example: The word is "in". The text is:

We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

* The expected result is:

We are living in a yellow submarine. We will move out of it in 5 days.

* Consider that the sentences are separated by "." and the words – by non-letter symbols.
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

internal class ExtractSentences
{
    private static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            int rgx = Regex.Matches(sentences[i], @"\b" + word + @"*\b").Count;
            if (rgx > 0)
            {
                result.Append(sentences[i] + '.');
            }

            rgx = 0;
        }

        Console.WriteLine(result.ToString());
    }
}
