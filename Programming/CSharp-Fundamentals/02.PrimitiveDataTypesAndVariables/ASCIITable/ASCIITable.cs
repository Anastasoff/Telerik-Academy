using System;

// 12. Find on-line more information about ASCII (American Standard Code for Information Interchange) 
// and write a program that prints the entire ASCII table of characters on the console.
class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 127; i++)
        {
            Console.WriteLine("Dec: {0,3} | Char: {1}", i, (char)i);
        }
    }
}
