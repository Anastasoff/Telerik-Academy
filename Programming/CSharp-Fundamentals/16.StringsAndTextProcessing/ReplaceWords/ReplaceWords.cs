/*
9. We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. 
* Example:

Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

* Words: "PHP, CLR, Microsoft"
* The expected result:

********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

using System;

internal class ReplaceWords
{
    private static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter the forbidden words: ");
        string words = Console.ReadLine();
        string[] listOfWords = words.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < listOfWords.Length; i++)
        {
            string replacement = new string('*', listOfWords[i].Length);
            text = text.Replace(listOfWords[i], replacement);
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '*')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text[i]);
                Console.ResetColor();
            }
            else
            {
                Console.Write(text[i]);
            }
        }

        Console.WriteLine();
    }
}
