// 1. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class ReadFileAndPrintOddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\SomeText.txt"))
        {
            int counter = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                counter++;
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
            }
        }
    }
}
