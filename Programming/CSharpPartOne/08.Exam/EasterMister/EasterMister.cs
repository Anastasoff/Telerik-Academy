namespace EasterMister
{
    using System;

    internal class EasterMister
    {
        private static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            // first row
            Console.Write(new string('.', number + 1));
            Console.Write(new string('*', number - 1));
            Console.WriteLine(new string('.', number + 1));

            // upper
            int index = 0;
            for (int row = 2; row <= number - 2; row += 2)
            {
                Console.Write(new string('.', (number + 1) - row));
                Console.Write('*');
                Console.Write(new string('.', (number + 1) + index));
                Console.Write('*');
                Console.Write(new string('.', (number + 1) - row));

                Console.WriteLine();

                index += 4;
            }

            for (int row = 1; row <= (number / 2) - 1; row++)
            {
                Console.Write('.');
                Console.Write('*');

                Console.Write(new string('.', (number * 3) - 3));

                Console.Write('*');
                Console.Write('.');

                Console.WriteLine();
            }

            // center
            Console.Write(".*");
            for (int i = 0; i < (number * 3) - 3; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }
            }

            Console.Write("*.");
            Console.WriteLine();

            Console.Write(".*");
            for (int i = 0; i < (number * 3) - 3; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.Write("*.");
            Console.WriteLine();

            // lower
            for (int row = 1; row <= (number / 2) - 1; row++)
            {
                Console.Write('.');
                Console.Write('*');

                Console.Write(new string('.', (number * 3) - 3));

                Console.Write('*');
                Console.Write('.');

                Console.WriteLine();
            }

            index = (number * 3) - 3;
            for (int i = 1; i <= number - 2; i += 2)
            {
                index -= 4;
                Console.Write(new string('.', i + 2));
                Console.Write('*');
                Console.Write(new string('.', index));
                Console.Write('*');
                Console.Write(new string('.', i + 2));

                Console.WriteLine();
            }

            // last row
            Console.Write(new string('.', number + 1));
            Console.Write(new string('*', number - 1));
            Console.WriteLine(new string('.', number + 1));
        }
    }
}