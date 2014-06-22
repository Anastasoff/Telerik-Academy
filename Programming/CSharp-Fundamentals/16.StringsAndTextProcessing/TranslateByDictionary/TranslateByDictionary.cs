/*
14. A dictionary is stored as a sequence of text lines containing words and their explanations. 
      Write a program that enters a word and translates it by using the dictionary. 
      Sample dictionary:

.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes
*/

using System;
using System.Collections.Generic;

internal class TranslateByDictionary
{
    private static void Main()
    {
        Console.Write("Enter a word: ");
        string keyWord = Console.ReadLine();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        if (dictionary.ContainsKey(keyWord) == true)
        {
            Console.WriteLine("{0} - {1}", keyWord, dictionary[keyWord]);
        }
        else
        {
            Console.WriteLine("Wrong key word!");
        }
    }
}
