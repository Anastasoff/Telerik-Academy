// 23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
//      Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;
using System.Text.RegularExpressions;

internal class ConsecutiveIdenticalLetters
{
    private static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        //// Regex regex = new Regex("(.)\\1+");
        //// Console.WriteLine(regex.Replace(text, "$1"));

        StringBuilder replaced = new StringBuilder();
        char previousChar = '\0';
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != previousChar)
            {
                replaced.Append(text[i]);
                previousChar = text[i];
            }
        }

        Console.WriteLine(replaced.ToString());
    }
}
