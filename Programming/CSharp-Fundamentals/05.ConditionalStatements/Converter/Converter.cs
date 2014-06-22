using System;

/* 11. * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
 * Examples:
 * 0 -> "Zero"
 * 273 -> "Two hundred seventy three"
 * 400 -> "Four hundred"
 * 501 -> "Five hundred and one"
 * 711 -> "Seven hundred and eleven"
 */ 
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ToUpperFirstLetter(IntegerToWritten(number)));
    }

    static string ToUpperFirstLetter(string source)
    {
        if (string.IsNullOrEmpty(source))
        {
            return string.Empty;
        }

        char[] letters = source.ToCharArray();
        letters[0] = char.ToUpper(letters[0]);

        return new string(letters);
    }

    static string IntegerToWritten(int n)
    {
        if (n == 0)
        {
            return "zero";
        }
        else if (n < 0)
        {
            return "negative " + IntegerToWritten(-n);
        }

        return FriendlyInteger(n, "");
    }

    static string FriendlyInteger(int n, string leftDigits)
    {
        string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (n == 0)
        {
            return leftDigits;
        }

        string friendlyInt = leftDigits;
        if (friendlyInt.Length > 0)
        {
            friendlyInt += " ";
        }

        if (n < 10)
        {
            friendlyInt += ones[n];
        }
        else if (n < 20)
        {
            friendlyInt += teens[n - 10];
        }
        else if (n < 100)
        {
            friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2]);
        }
        else
        {
            friendlyInt += FriendlyInteger(n % 100, (ones[n / 100] + " hundred"));
        }

        return friendlyInt;
    }
}