// My solution to the third problem form the exam. Points: 100

using System;

class BatGoikoTower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        for (int i = 0; i < h; i++)
        {
            // left side
            Console.Write(new string('.', (h - 1) - i));
            Console.Write(new string('/', 1));
            if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
            {
                Console.Write(new string('-', i)); // inside '-'
            }
            else
            {
                Console.Write(new string('.', i)); // inside '.'
            }

            // right side
            if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
            {
                Console.Write(new string('-', i)); // inside '-'
            }
            else
            {
                Console.Write(new string('.', i)); // inside '.'
            }

            Console.Write(new string('\\', 1));
            Console.Write(new string('.', (h - 1) - i));

            Console.WriteLine();
        }
    }
}
