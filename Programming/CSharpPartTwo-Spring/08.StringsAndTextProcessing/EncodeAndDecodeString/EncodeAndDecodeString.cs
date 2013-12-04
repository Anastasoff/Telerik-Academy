/*
7. Write a program that encodes and decodes a string using given encryption key (cipher). 
The key consists of a sequence of characters. 
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
the second – with the second, etc. When the last key character is reached, the next is the first.
Example:
 * text: Proceed to the following coordinates.
 * cipher: UQJHSE
*/

using System;
using System.Text;

internal class EncodeAndDecodeString
{
    private static void Main()
    {
        Console.Write("Enter a text: ");
        string inputText = Console.ReadLine();
        Console.Write("Enter the key: ");
        string cipher = Console.ReadLine();

        string encrypted = EncryptOrDecrypt(inputText, cipher);
        Console.WriteLine("Encrypted: {0}", encrypted);

        string decrypted = EncryptOrDecrypt(encrypted, cipher);
        Console.WriteLine("Decrypted: {0}", decrypted);
    }

    private static string EncryptOrDecrypt(string text, string cipher)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            int charCode = (int)character;
            int keyPosition = i % cipher.Length;
            char keyChar = cipher[keyPosition];
            int keyCode = (int)keyChar;
            int combinedCode = charCode ^ keyCode;
            char combinedChar = (char)combinedCode;
            result.Append(combinedChar);
        }

        return result.ToString();
    }
}
