// 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Text.RegularExpressions;

internal class ExtractPalindromes
{
    private static bool CheckIsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    private static void Main()
    {
        string text = @"Nice blue sky. No exe flying in the sky. 
                ABBA will not come in Bulgaria. I don`t know what is lamal, 
                maybe I will find some day. Let's try with 12345 and 0123210!";

        //// (?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!)) -> extracts all palindromes
        foreach (Match word in Regex.Matches(text, @"\w+")) 
        {
            if (CheckIsPalindrome(word.Value) && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
