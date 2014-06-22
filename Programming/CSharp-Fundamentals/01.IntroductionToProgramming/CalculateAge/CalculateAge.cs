// *12. * Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Write("Enter your current age: ");
            string inputAge = Console.ReadLine();

            int age;
            bool isValidAge = int.TryParse(inputAge, out age);

            if (isValidAge && age > 0 && age < 120)
            {
                int yearsToAdd = 10;
                Console.WriteLine("After {0} years you will be {1} years old.", yearsToAdd, age + yearsToAdd);
                break;
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        } while (true);
    }
}
