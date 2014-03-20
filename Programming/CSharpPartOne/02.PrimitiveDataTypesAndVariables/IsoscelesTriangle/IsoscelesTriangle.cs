using System;
using System.Text;

// 9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol. 
// Note: the © symbol may be displayed incorrectly.
class IsoscelesTriangle
{
    static void Main()
    {
        Console.Write("Enter triangle's height: ");
        int triangleRows = int.Parse(Console.ReadLine());

        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00A9';

        for (int row = 1; row <= triangleRows; row++)
        {
            Console.Write(new string(' ', triangleRows - row));
            Console.WriteLine(new string(symbol, (row * 2) - 1));
        }

        Console.WriteLine(new string('=', (triangleRows * 2) - 1));

        for (int i = 1; i <= triangleRows; i++)
        {
            for (int j = 0; j < triangleRows - i; j++)
            {
                Console.Write(' ');
            }

            for (int j = 0; j < (i * 2) - 1; j++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
