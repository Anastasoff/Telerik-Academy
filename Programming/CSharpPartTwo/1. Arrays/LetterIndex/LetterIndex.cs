// 12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
//      Read a word from the console and print the index of each of its letters in the array.

using System;

class LetterIndex
{
    static void Main()
    {
        // input
        Console.Write("Enter a word: ");
        string inputWord = (Console.ReadLine().ToUpper());

        char[] alphabet = new char[26];
        // filling an array
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65);
        }
        // searching in an array and printing
        for (int i = 0; i < inputWord.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (inputWord[i] == alphabet[j])
                {
                    Console.WriteLine("Index of {0} is {1}", inputWord[i], j);
                }
            }
        }        
    }
}
