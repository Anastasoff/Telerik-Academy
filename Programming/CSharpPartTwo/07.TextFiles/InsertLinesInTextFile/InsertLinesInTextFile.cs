// 3. Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//      The result should be written to another text file.

using System;
using System.IO;

class InsertLinesInTextFile
{
    static void Main()
    {
        string fileToRead = @"..\..\ReadMe.txt";
        string fileToWrite = @"..\..\WriteMe.txt";

        using (StreamReader reader = new StreamReader(fileToRead))
        {
            using (StreamWriter writer = new StreamWriter(fileToWrite))
            {
                int lineNumber = 1;
                string content = reader.ReadLine();

                while (content != null)
                {
                    writer.WriteLine("Line {0}: {1}", lineNumber, content);
                    lineNumber++;
                    content = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("File is written!");
    }
}
