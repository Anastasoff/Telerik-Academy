/*
* 3. Write a program that counts how many times each word from
* given text file words.txt appears in it. The character casing
* differences should be ignored. The result words should be
* ordered by their number of occurrences in the text.
*
* Example:
*
* This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
*
* is -> 2
* the -> 2
* this -> 3
* text -> 6
*/

namespace CountWordsInFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        public static IDictionary<string, int> FindOccurrences(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }

            var occurrences = new SortedDictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < array.Length; i++)
            {
                string currentValue = array[i].ToLower();
                if (occurrences.ContainsKey(currentValue))
                {
                    occurrences[currentValue]++;
                }
                else
                {
                    occurrences[currentValue] = 1;
                }
            }
            return occurrences;
        }

        public static string ReadTextFromFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty.", "path");
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Could not find the file specified.", path);
            }

            return File.ReadAllText(path);
        }

        public static void Main()
        {
            string path = "../../input.txt";
            string input = ReadTextFromFile(path);

            char[] separators = new char[] { ' ', '.', ',', '-', '–', '!', '?', '\'', '"', ';', ':' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var occurrences = FindOccurrences(words);
            var orderedByValue = occurrences.OrderBy(v => v.Value);
            foreach (var item in orderedByValue)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}