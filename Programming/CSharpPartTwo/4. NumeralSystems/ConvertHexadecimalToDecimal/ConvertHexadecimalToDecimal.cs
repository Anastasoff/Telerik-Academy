// 4. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Linq;

class ConvertHexadecimalToDecimal
{
    static int Pow(int counter)
    {
        return (1 << (counter << 2));
    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number (0x....): ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        int counter = number.Length - 1;
        int digit = 0;
        int result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case 'A':
                    digit = 10;
                    break;
                case 'B':
                    digit = 11;
                    break;
                case 'C':
                    digit = 12;
                    break;
                case 'D':
                    digit = 13;
                    break;
                case 'E':
                    digit = 14;
                    break;
                case 'F':
                    digit = 15;
                    break;
                default:
                    digit = int.Parse(Convert.ToString(number[i]));
                    break;
            }

            result = result + digit * Pow(counter);
            counter--;
        }

        Console.WriteLine(result);
    }
}