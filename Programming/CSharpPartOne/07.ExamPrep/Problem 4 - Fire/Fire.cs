using System;

class Fire
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input / 2; i++)
        {
            Console.Write(new string('.', (input / 2) - i - 1));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', i));

            Console.Write(new string('.', i));
            Console.Write(new string('#', 1));
            Console.WriteLine(new string('.', (input / 2) - i - 1));
        }

        for (int i = 0; i < input / 4; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', (input / 2) - i - 1));

            Console.Write(new string('.', (input / 2) - i - 1));
            Console.Write(new string('#', 1));
            Console.WriteLine(new string('.', i));
        }

        Console.WriteLine(new string('-', input));

        for (int i = 0; i < input / 2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', (input / 2) - i));
            Console.Write(new string('/', (input / 2) - i));
            Console.WriteLine(new string('.', i));
        }
    }
}