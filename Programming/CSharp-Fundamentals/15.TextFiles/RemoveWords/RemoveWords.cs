// 12. Write a program that removes from a text file all words listed in given another text file. 
//      Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void RemoveWord()
    {
        List<string> wordsToRemove = new List<string>();
        using (StreamReader toRemoveReader = new StreamReader(@"..\..\toRemove.txt"))
        {
            for (string readLine = toRemoveReader.ReadLine(); readLine != null; readLine = toRemoveReader.ReadLine())
            {
                wordsToRemove.Add(readLine);
            }
        }

        using (StreamReader inputReader = new StreamReader(@"..\..\input.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                for (string readLine = inputReader.ReadLine(); readLine != null; readLine = inputReader.ReadLine())
                {
                    for (int i = 0; i < wordsToRemove.Count; i++)
                    {
                        readLine = Regex.Replace(readLine, @"\b" + wordsToRemove[i] + @"(\s|\S)\b", string.Empty);
                    }

                    writer.WriteLine(readLine);
                }
            }
        }

        Console.WriteLine("File is written!");
    }

    static void Main()
    {
        try
        {
            RemoveWord();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Exception caught! "  + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Exception caught! " + ex.Message);
        }
    }
}
