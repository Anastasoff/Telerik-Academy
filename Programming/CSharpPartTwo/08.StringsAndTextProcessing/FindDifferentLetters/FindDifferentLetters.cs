// 21. Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

internal class FindDifferentLetters
{
    private static void Main()
    {
        string text = @"Works with lowercase and UPPERCASE letters!";
        MatchCollection onlyLetters = Regex.Matches(text, @"[A-Za-z]");
        SortedDictionary<string, int> usedLetters = new SortedDictionary<string, int>();

        for (int i = 0; i < onlyLetters.Count; i++)
        {
            if (!usedLetters.ContainsKey(onlyLetters[i].Value))
            {
                usedLetters.Add(onlyLetters[i].Value, 1);
            }
            else
            {
                usedLetters[onlyLetters[i].Value]++;
            }
        }

        var total = usedLetters.Skip(1).Sum(x => x.Value);
        foreach (KeyValuePair<string, int> letter in usedLetters)
        {
            Console.WriteLine("Letter: {0, -3}=> Counts: {1, 2}", letter.Key, letter.Value);
        }

        Console.WriteLine("\nNumber of letters: {0}\n", total);
    }
}
