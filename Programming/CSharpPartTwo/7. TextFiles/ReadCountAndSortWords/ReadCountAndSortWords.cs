/*
13. Write a program that reads a list of words from a file words.txt 
    and finds how many times each of the words is contained in another file test.txt. 
    The result should be written in the file result.txt 
    and the words should be sorted by the number of their occurrences in descending order. 
    Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ReadCountAndSortWords
{
    static void ReadAndCount()
    {
        string[] words = File.ReadAllLines(@"..\..\words.txt");
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            int[] counts = new int[words.Length];
            for (string readLine = reader.ReadLine(); readLine != null; readLine = reader.ReadLine())
            {
                for (int i = 0; i < words.Length; i++)
                {
                    counts[i] = counts[i] + Regex.Matches(readLine, @"\b" + words[i] + @"*\b").Count;
                }
            }

            Array.Sort(counts, words);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                writer.WriteLine("{0}: {1}", words[i], counts[i]);
            }
        }

        Console.WriteLine("File is written!");
    }

    static void Main()
    {
        try
        {
            ReadAndCount();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
    }
}
