using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    private static int GetDurankulakNumbers(string number)
    {
        Dictionary<string, int> durankulakNumbers = new Dictionary<string, int>();

        for (int i = 0; i < 26; i++)
        {
            durankulakNumbers.Add(((char)(i + 65)).ToString(), i);
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                durankulakNumbers.Add(((char)(i + 97)).ToString() + ((char)(j + 65)).ToString(), durankulakNumbers.Count);
            }
        }

        int result = -1;
        if (durankulakNumbers.ContainsKey(number))
        {
            result = durankulakNumbers[number];
        }

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();
        List<int> list = new List<int>();

        string currentNumber = string.Empty;
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            currentNumber += number[i];

            if (((char)currentNumber[currentNumber.Length - 1]) <= 'Z')
            {
                result = GetDurankulakNumbers(currentNumber);
                list.Add(result);
                result = 0;
                currentNumber = string.Empty;
            }
        }

        ulong decimalResult = 0;
        for (int i = 0; i < list.Count; i++)
        {
            decimalResult += (ulong)list[i] * (ulong)Math.Pow(168, list.Count - 1 - i);
        }

        Console.WriteLine(decimalResult);
    }
}
