// 4. Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;

class CountNumberInArray
{
    static int CountNumber(int[] arr, int number)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter a number to find: ");
        int number = int.Parse(Console.ReadLine());

        int result = CountNumber(arr, number);
        Console.WriteLine("{0} ---> {1} times", number, result);
    }
}
