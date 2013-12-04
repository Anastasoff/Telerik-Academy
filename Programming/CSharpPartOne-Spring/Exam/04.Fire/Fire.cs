using System;

class Fire
{
    static void Main()
    {
        // not finished

        int n = 12;
        // up side
        for (int i = 0; i <= n / 2; i++)
        {
            // left side
            Console.Write(new string('.', (n / 2) - i));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', i));

            // right side
            Console.Write(new string('.', i));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', (n / 2) - i));

            Console.WriteLine();           
        }

        // down side
        for (int i = 0; i < n / 4; i++)
        {
            Console.Write(new string('.', i + 1));
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', n));
    }
}
