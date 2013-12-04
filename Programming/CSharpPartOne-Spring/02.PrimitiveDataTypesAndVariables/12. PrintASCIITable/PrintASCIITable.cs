/* 12. Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the entire ASCII table of characters on the console. */

using System;

class PrintASCIITable
{
    static void Main()
    {
                for (int i = 0; i < 128; i++)
        {
            char letter = (char)i;
            Console.WriteLine(i + " -> " +letter);
        }
    }
}
