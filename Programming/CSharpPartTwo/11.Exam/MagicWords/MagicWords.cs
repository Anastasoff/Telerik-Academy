using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static void Main()
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < numberOfWords; i++)
        {
            words.Add(Console.ReadLine());
        }

        if (words.Count == 1)
        {
            // do nothing
        }
        else
        {
            for (int i = 0; i < numberOfWords; i++)
            {
                string currentWord = words[i];
                int newPosistion = currentWord.Length % (numberOfWords + 1);
                if (newPosistion < 0)
                {
                    newPosistion = newPosistion + words.Count;
                }

                words.Insert(newPosistion, currentWord);
                int position = words.IndexOf(currentWord, newPosistion + 1);
                if (position < 0)
                {
                    words.Remove(currentWord);
                }
                else
                {
                    words.RemoveAt(position);
                }
            }
        }

        string longest = string.Empty;
        foreach (string lng in words)
        {
            if (lng.Length > longest.Length)
            {
                longest = lng;
            }
        }

        StringBuilder printer = new StringBuilder();
        for (int i = 0; i < longest.Length; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                string printCurrent = words[j];
                if (printCurrent.Length > i)
                {
                    if (char.IsLetter(printCurrent[i]))
                    {
                        printer.Append(printCurrent[i]);
                    }
                }
            }
        }

        Console.WriteLine(printer.ToString());
    }
}