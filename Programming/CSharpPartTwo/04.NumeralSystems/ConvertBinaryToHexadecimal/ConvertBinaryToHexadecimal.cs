// 6. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class ConvertBinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string str = Console.ReadLine();
        if (str.Length % 4 == 1)
        {
            str = "000" + str;
        }
        else if (str.Length % 4 == 2)
        {
            str = "00" + str;
        }
        else if (str.Length % 4 == 3)
        {
            str = "0" + str;
        }

        string result = string.Empty;
        for (int i = 0; i < str.Length; i = i + 4)
        {
            switch (str.Substring(i, 4))
            {
                case "0000":
                    result += "0";
                    break;
                case "0001":
                    result += "1";
                    break;
                case "0010":
                    result += "2";
                    break;
                case "0011":
                    result += "3";
                    break;
                case "0100":
                    result += "4";
                    break;
                case "0101":
                    result += "5";
                    break;
                case "0110":
                    result += "6";
                    break;
                case "0111":
                    result += "7";
                    break;
                case "1000":
                    result += "8";
                    break;
                case "1001":
                    result += "9";
                    break;
                case "1010":
                    result += "A";
                    break;
                case "1011":
                    result += "B";
                    break;
                case "1100":
                    result += "C";
                    break;
                case "1101":
                    result += "D";
                    break;
                case "1110":
                    result += "E";
                    break;
                case "1111":
                    result += "F";
                    break;
                default:
                    result += string.Empty;
                    break;
            }
        }

        Console.WriteLine(result);
    }
}