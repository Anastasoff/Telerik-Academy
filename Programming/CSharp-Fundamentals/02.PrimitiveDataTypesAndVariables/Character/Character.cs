using System;

// 5. Declare a character variable and assign it with the symbol that has Unicode code 72. 
// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
class Character
{
    static void Main()
    {
        // two ways
        char firstChar = '\u0048';
        Console.WriteLine(firstChar);

        char secondChar = (char)72;
        Console.WriteLine(secondChar);
    }
}
