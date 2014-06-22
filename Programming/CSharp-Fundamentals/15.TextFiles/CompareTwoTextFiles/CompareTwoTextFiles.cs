// 4. Write a program that compares two text files line by line and prints the number of lines that are the same 
//      and the number of lines that are different. 
//      Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTwoTextFiles
{
    static void Main()
    {
        string firstTextFile = @"..\..\firstFile.txt";
        string secondTextFile = @"..\..\secondFile.txt";

        int sameLines = 0;
        int differentLines = 0;

        using (StreamReader firstReader = new StreamReader(firstTextFile))
        {
            using (StreamReader secondReader = new StreamReader(secondTextFile))
            {
                string lineFirstFile = firstReader.ReadLine();
                string lineSecondFile = secondReader.ReadLine();

                while (lineFirstFile != null && lineSecondFile != null)
                {
                    if (lineFirstFile == lineSecondFile)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    lineFirstFile = firstReader.ReadLine();
                    lineSecondFile = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Same lines: {0}", sameLines);
        Console.WriteLine("Different lines: {0}", differentLines);
    }
}
