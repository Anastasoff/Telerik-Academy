// 3. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<string> hexadecimalList = new List<string>();

        if (number == 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 10:
                        hexadecimalList.Add("A");
                        break;
                    case 11:
                        hexadecimalList.Add("B");
                        break;
                    case 12:
                        hexadecimalList.Add("C");
                        break;
                    case 13:
                        hexadecimalList.Add("D");
                        break;
                    case 14:
                        hexadecimalList.Add("E");
                        break;
                    case 15:
                        hexadecimalList.Add("F");
                        break;
                    default:
                        hexadecimalList.Add(number.ToString());
                        break;
                }

                number = number / 16;
            }

            for (int i = hexadecimalList.Count - 1; i > -1; i--)
            {
                Console.Write(hexadecimalList[i]);
            }

            Console.WriteLine();
        }
    }
}
