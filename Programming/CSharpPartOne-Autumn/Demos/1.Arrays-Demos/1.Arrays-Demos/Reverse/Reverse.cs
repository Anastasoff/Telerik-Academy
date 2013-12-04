using System;

class Reverse
{
    static void Main()
    {
        int[] array = new int[] { 9,8,7,6,5,3,0,-2,-5 };

        // Get array size
        int length = array.Length;

        // Declare and create the reversed array
        int[] reversed = new int[length];

        // Initialize the reversed array
        for (int index = 0; index < length; index++)
        {
            reversed[length - index - 1] = array[index];
        }

        // Print the reversed array elements
        for (int index = 0; index < length; index++)
        {
            Console.Write(reversed[index] + " ");
        } 
        Console.WriteLine();
    }
}
