// 3. Write a program that finds the biggest of three integers using nested if statements.

using System;

class FindTheBiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int intOne = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int intTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int intThree = int.Parse(Console.ReadLine());

        if (intOne > intTwo && intOne > intThree)
        {

            Console.WriteLine("The biggest integer is: {0}", intOne);
        }
        else
        {
            if (intTwo > intOne && intTwo > intThree)
            {

                Console.WriteLine("The biggest integer is: {0}", intTwo);
            }
            else
            {
                if (intThree > intOne && intThree > intTwo)
                {
                    Console.WriteLine("The biggest integer is: {0}", intThree);
                }
                else
                {
                    Console.WriteLine("Two or more integers are equal.");
                }
            }
        }
    }
}
