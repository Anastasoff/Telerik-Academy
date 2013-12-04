/* 10. Write a program that applies bonus scores to given scores in the range [1..9]. 
       The program reads a digit as an input. 
       If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
       if it is between 7 and 9, multiplies it by 1000. 
       If it is zero or if the value is not a digit, the program 	must report an error.
       Use a switch statement and at the end print the calculated new value in the console.
*/
using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter scores (1-9): ");
        int score = int.Parse(Console.ReadLine());

        int result = 0;

        switch (score)
        {
            // the digit is between 1 and 3
            case 1:
            case 2:
            case 3:
                result = score * 10;
                Console.WriteLine("The bonus scores are: {0}", result);
                break;

            // the digit is between 4 and 6
            case 4:
            case 5:
            case 6:
                result = score * 100;
                Console.WriteLine("The bonus scores are: {0}", result);
                break;

            // the digit is between 7 and 9
            case 7:
            case 8:
            case 9:
                result = score * 1000;
                Console.WriteLine("The bonus scores are: {0}", result);
                break;

            // if the value is zero or not a digit
            default:
                Console.WriteLine("Error!");
                Console.WriteLine("Please try again!");
                break;
        }
    }
}
