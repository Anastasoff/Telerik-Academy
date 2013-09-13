// 2. Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareElementsOfArrays
{
    static void Main()
    {
        // input
        Console.Write("Enter first array length: ");
        int firstArrSize = int.Parse(Console.ReadLine());

        Console.Write("Enter second array length: ");
        int secondArrSize = int.Parse(Console.ReadLine());

        string[] firstArr = new string[firstArrSize];
        string[] secondArr = new string[secondArrSize];

        bool isEqual = true;

        // filling arrays
        Console.WriteLine();
        Console.WriteLine("First array.");
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter {0} element value: ", i);
            firstArr[i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Second array.");
        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("Enter {0} element value: ", i);
            secondArr[i] = Console.ReadLine();
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine();

        // comparing and printing
        if (firstArr.Length != secondArr.Length)
        {
            Console.WriteLine("The two arrays are not equal, they have different lengths!");
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual == true)
            {
                Console.WriteLine("The two arrays are equal!");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal!");
            }
        }
    }
}
