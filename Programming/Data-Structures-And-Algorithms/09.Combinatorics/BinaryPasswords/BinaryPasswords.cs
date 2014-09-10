namespace BinaryPasswords
{
    using System;

    public class BinaryPasswords
    {
        public static void Main()
        {
            string password = Console.ReadLine();

            int missingDigits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '*')
                {
                    missingDigits++;
                }
            }

            long numberOfPossiblePasswords = 1;
            for (int i = 0; i < missingDigits; i++)
            {
                numberOfPossiblePasswords *= 2;
            }

            Console.WriteLine(numberOfPossiblePasswords);
        }
    }
}