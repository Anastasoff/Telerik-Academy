using System;
using System.Collections.Generic;

internal class MultiverseCommunication
{
    private static int GetNumbers(string number)
    {
        Dictionary<string, int> numbersDic = new Dictionary<string, int>();
        numbersDic.Add("CHU", 0);
        numbersDic.Add("TEL", 1);
        numbersDic.Add("OFT", 2);
        numbersDic.Add("IVA", 3);
        numbersDic.Add("EMY", 4);
        numbersDic.Add("VNB", 5);
        numbersDic.Add("POQ", 6);
        numbersDic.Add("ERI", 7);
        numbersDic.Add("CAD", 8);
        numbersDic.Add("K-A", 9);
        numbersDic.Add("IIA", 10);
        numbersDic.Add("YLO", 11);
        numbersDic.Add("PLA", 12);

        int result = -1;
        if (numbersDic.ContainsKey(number))
        {
            result = numbersDic[number];
        }

        return result;
    }

    private static ulong Power(ulong number, int power)
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

    private static void Main()
    {
        string numberStr = Console.ReadLine();

        string currentNum = string.Empty;
        string multiComResult = string.Empty;
        List<string> numbersInList = new List<string>();
        for (int i = 0; i < numberStr.Length; i++)
        {
            currentNum += numberStr[i];
            if (GetNumbers(currentNum) != -1)
            {
                int result = GetNumbers(currentNum);
                numbersInList.Add(result.ToString());
                currentNum = string.Empty;
            }
        }

        ulong decimalNumber = 0;

        for (int i = numbersInList.Count - 1, j = 0; i >= 0; i--, j++)
        {
            decimalNumber += ulong.Parse(numbersInList[numbersInList.Count - 1 - j]) * (ulong)Math.Pow(13, j);
        }

        Console.WriteLine(decimalNumber);
    }
}