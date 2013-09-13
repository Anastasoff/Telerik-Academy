/*
3. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
reads its contents and prints it on the console. 
Find in MSDN how to use System.IO.File.ReadAllText(…). 
Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;

class ReadFromTextFile
{
    static void ReadFile(string filePath)
    {
        StreamReader dataFile = new StreamReader(filePath);

        using (dataFile)
        {
            string fileContents = dataFile.ReadToEnd();
            Console.WriteLine(fileContents);
        }
    }

    static void Main()
    {
        string filePath = @"..\.\data.txt";
        // Console.Write("Enter file path and name: ");
        // string filePath = Console.ReadLine();

        try
        {
            ReadFile(filePath);
        }
        catch (Exception exception)
        {
            Console.WriteLine("Exception cought!");
            Console.WriteLine(exception.GetType().Name);
            Console.WriteLine(exception.Message);
        }
    }
}
