// 22. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

internal class FindDifferentWords
{
    private static void Main()
    {
        string text = @"Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
        MatchCollection onlyWords = Regex.Matches(text, @"\w+");
        SortedDictionary<string, int> usedWords = new SortedDictionary<string, int>();

        for (int i = 0; i < onlyWords.Count; i++)
        {
            if (!usedWords.ContainsKey(onlyWords[i].Value))
            {
                usedWords.Add(onlyWords[i].Value, 1);
            }
            else
            {
                usedWords[onlyWords[i].Value]++;
            }
        }

        var total = usedWords.Skip(1).Sum(x => x.Value);
        foreach (KeyValuePair<string, int> word in usedWords)
        {
            Console.WriteLine("Word: {0, -15}=> Counts: {1, 2}", word.Key, word.Value);
        }

        Console.WriteLine("\nNumber of words: {0}\n", total);
    }
}
