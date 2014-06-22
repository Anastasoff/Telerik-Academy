// 13. Write a program that reverses the words in given sentence.
//      Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

internal class ReverseWordsInSentence
{
    private static void Main()
    {
        Console.Write("Enter a sentence: ");
        string inputText = Console.ReadLine();
        string[] listOfWords = inputText.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        string[] listOfSigns = inputText.Split(listOfWords, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder reversed = new StringBuilder();

        for (int i = listOfWords.Length - 1, j = 0; i >= 0; i--, j++)
        {
            reversed.Append(listOfWords[i] + listOfSigns[j]);
        }

        Console.WriteLine(reversed.ToString());
    }
}
