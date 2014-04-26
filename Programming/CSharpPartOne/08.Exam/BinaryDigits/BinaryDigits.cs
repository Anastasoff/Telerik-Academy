namespace BinaryDigits
{
    using System;

    internal class BinaryDigits
    {
        private static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            char[] bits = new char[16];

            for (int i = 0; i < 16; i++)
            {
                int mask = 1 << i;
                int numberAndMask = inputNumber & mask;
                int bit = numberAndMask >> i;

                if (bit == 1)
                {
                    bits[i] = '1';
                }
                else
                {
                    bits[i] = '0';
                }
            }

            char[] reversed = new char[16];
            for (int i = 16 - 1; i >= 0; i--)
            {
                reversed[16 - i - 1] = bits[i];
            }

            for (int i = 0; i < 16; i++)
            {
                if (reversed[i] == '0')
                {
                    Console.Write("###");
                }
                else if (reversed[i] == '1')
                {
                    Console.Write(".#.");
                }

                if (i < 15)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                if (reversed[i] == '0')
                {
                    Console.Write("#.#");
                }
                else if (reversed[i] == '1')
                {
                    Console.Write("##.");
                }

                if (i < 15)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                if (reversed[i] == '0')
                {
                    Console.Write("#.#");
                }
                else if (reversed[i] == '1')
                {
                    Console.Write(".#.");
                }

                if (i < 15)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                if (reversed[i] == '0')
                {
                    Console.Write("###");
                }
                else if (reversed[i] == '1')
                {
                    Console.Write("###");
                }

                if (i < 15)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}