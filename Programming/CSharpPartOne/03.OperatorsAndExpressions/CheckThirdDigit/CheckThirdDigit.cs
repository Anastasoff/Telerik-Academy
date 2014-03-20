using System;

// 4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position (starts with 0): ");
        int position = int.Parse(Console.ReadLine());
        for (int i = 0; i < position; i++)
        {
            number = (number - (number % 10)) / 10;
        }

        number %= 10;
        Console.WriteLine("Digit '{0}' is at position [{1}]", number, position);
    }
}
