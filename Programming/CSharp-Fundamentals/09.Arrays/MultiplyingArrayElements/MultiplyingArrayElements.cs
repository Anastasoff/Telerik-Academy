/* 1. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.*/

using System;

class MultiplyingArrayElements
{
    static void Main()
    {
        // input
        int[] intArray = new int[20];

        // initializing and multiplying
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i * 5;
        }

        // printing
        foreach (int index in intArray)
        {
            Console.WriteLine(index);
        }

        //for (int i = 0; i < intArray.Length; i++)
        //{
        //    Console.WriteLine(intArray[i]);
        //}
    }
}
