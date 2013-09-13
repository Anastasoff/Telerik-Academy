using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        int maxLineLength = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < linesCount; i++)
        {
            string readCurrentLine = Console.ReadLine();
            builder.Append(readCurrentLine.Trim() + " ");
        }

        string[] currentLineWords = builder.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> listOfWords = new List<string>(currentLineWords);
        do
        {
            builder.Clear();
            builder.Append(listOfWords[0]);
            int currentWord = 1;
            while (builder.Length < maxLineLength && currentWord < listOfWords.Count)
            {
                builder.Append(" " + listOfWords[currentWord]);
                currentWord++;
            }

            if (builder.Length > maxLineLength)
            {
                builder.Remove(builder.Length - listOfWords[currentWord - 1].Length - 1, listOfWords[currentWord - 1].Length + 1);
                currentWord--;
            }

            if (builder.Length == maxLineLength || currentWord == 1)
            {
                Console.WriteLine(builder);
                listOfWords.RemoveRange(0, currentWord);
                continue;
            }

            int spacecount = currentWord - 1;
            int sizeOfSpaces = (maxLineLength - builder.Length + spacecount) / spacecount;
            int numOfLongSpaces = (maxLineLength - builder.Length + spacecount) % spacecount;

            builder.Clear();
            builder.Append(listOfWords[0]);
            for (int i = 1; i <= spacecount; i++)
            {
                if (i <= numOfLongSpaces)
                {
                    builder.Append(" ");
                }

                builder.Append(new string(' ', sizeOfSpaces) + listOfWords[i]);
            }

            listOfWords.RemoveRange(0, currentWord);
            Console.WriteLine(builder);
        }
        while (listOfWords.Count > 0);
    }
}
