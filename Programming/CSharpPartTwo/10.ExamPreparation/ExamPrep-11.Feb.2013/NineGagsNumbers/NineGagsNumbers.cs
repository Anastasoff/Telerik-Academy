using System;
using System.Collections.Generic;

class NineGagsNumbers
{
    static int GetGagNumbers(string gagNumber)
    {
        Dictionary<string, int> gagNumbers = new Dictionary<string, int>();
        gagNumbers.Add("-!", 0);
        gagNumbers.Add("**", 1);
        gagNumbers.Add("!!!", 2);
        gagNumbers.Add("&&", 3);
        gagNumbers.Add("&-", 4);
        gagNumbers.Add("!-", 5);
        gagNumbers.Add("*!!!", 6);
        gagNumbers.Add("&*!", 7);
        gagNumbers.Add("!!**!-", 8);

        int result = -1;
        if (gagNumbers.ContainsKey(gagNumber))
        {
            result = gagNumbers[gagNumber];
        }

        return result;
    }

    static ulong Power(ulong number, int power)
    {
        if (number == 0 || power == 0)
        {
            return 1;
        }

        ulong result = number;
        for (int i = 1; i < power; i++)
        {
            result = result * number;
        }

        return result;
    }

    static void Main()
    {
        string gagNumber = Console.ReadLine();

        string currentNum = string.Empty;
        string gagResult = string.Empty;
        for (int i = 0; i < gagNumber.Length; i++)
        {
            currentNum += gagNumber[i];
            if (GetGagNumbers(currentNum) != -1)
            {
                gagResult += GetGagNumbers(currentNum);
                currentNum = string.Empty;
            }
        }

        // from gag to decimal
        ulong decimalNumber = 0;
        for (int i = 0; i < gagResult.Length; i++)
        {
            decimalNumber += ulong.Parse(gagResult[i].ToString()) * Power(9, gagResult.Length - 1 - i); 
        }

        Console.WriteLine(decimalNumber);
    }
}
