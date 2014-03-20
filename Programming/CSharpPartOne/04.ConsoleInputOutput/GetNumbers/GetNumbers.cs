using System;

// 7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
class GetNumbers
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        do
        {
            Console.Write("Enter a number: ");
            sum += int.Parse(Console.ReadLine());
            number--;
        } while (number > 0);

        Console.WriteLine("Sum = {0}", sum);
    }
}
