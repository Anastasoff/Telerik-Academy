/*
6. Write a program that reads a text file containing a list of strings, 
    sorts them and saves them to another text file. 
Example:

	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ReadSortAndSaveStrings
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            List<string> fileContent = new List<string>();
            string readLine = reader.ReadLine();

            while (readLine != null)
            {
                fileContent.Add(readLine);
                readLine = reader.ReadLine();
            }

            fileContent.Sort();

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                for (int i = 0; i < fileContent.Count; i++)
                {
                    writer.WriteLine(fileContent[i]);
                }
            }
        }

        // string[] fileContent = File.ReadLines("../../input.txt").ToArray();
        // Array.Sort(fileContent);
        // File.WriteAllLines("../../output.txt", fileContent);

        Console.WriteLine("File is written!");
    }
}
