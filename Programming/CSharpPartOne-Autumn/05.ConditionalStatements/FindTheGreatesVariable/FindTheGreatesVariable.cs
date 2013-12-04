using System;

// 7. Write a program that finds the greatest of given 5 variables.
class FindTheGreatesVariable
{
    static void Main()
    {
        Console.Write("Enter the number of variables: ");
        int variables = int.Parse(Console.ReadLine());

        int greatest = int.MinValue;
        int temp = 0;
        for (int i = 0; i < variables; i++)
        {
            Console.Write("Enter an integer variable[{0}]: ", i + 1);
            temp = int.Parse(Console.ReadLine());
            if (temp > greatest)
            {
                greatest = temp;
            }
        }

        Console.WriteLine("The greatest variable is: {0}", greatest);
    }
}
