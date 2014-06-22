// 24 .Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class SortListOfWords
{
    private static void Main()
    {
        // TODO: remove extracted letters like 's' in it's
        string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
        List<string> listOfWords = new List<string>();
        MatchCollection rgx = Regex.Matches(text, @"\w+");
        for (int i = 0; i < rgx.Count; i++)
        {
            listOfWords.Add(rgx[i].Value);
        }

        listOfWords.Sort();
        for (int i = 0; i < listOfWords.Count; i++)
        {
            Console.WriteLine("{0, 2}: {1}", i + 1, listOfWords[i]);
        }
    }
}
