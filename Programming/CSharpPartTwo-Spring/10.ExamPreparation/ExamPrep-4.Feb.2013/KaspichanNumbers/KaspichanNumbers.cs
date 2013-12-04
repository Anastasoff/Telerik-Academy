using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    private static void GetKaspichanNumbers(List<string> kaspichanNumbers)
    {
        for (char i = 'A'; i <= 'Z'; i++)
        {
            kaspichanNumbers.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                kaspichanNumbers.Add(i.ToString() + j.ToString());
            }
        }
    }

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<string> kaspichanNumbers = new List<string>();
        GetKaspichanNumbers(kaspichanNumbers);

        string result = string.Empty;
        if (number == 0)
        {
            Console.WriteLine('A');
        }
        else
        {
            while (number > 0)
            {
                result = kaspichanNumbers[(int)(number % 256)] + result;
                number = number / 256;
            }

            Console.WriteLine(result);
        }
    }
}
