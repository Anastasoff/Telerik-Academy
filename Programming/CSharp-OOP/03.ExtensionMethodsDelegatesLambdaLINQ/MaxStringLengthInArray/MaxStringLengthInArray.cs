// Write a program to return the string with maximum length from an array of strings. Use LINQ.
namespace MaxStringLengthInArray
{
    using System;
    using System.Linq;
    using System.Text;

    internal class MaxStringLengthInArray
    {
        private static void Main()
        {
            string[] arrayOfStrings = RandomStringGenerator();

            foreach (var item in arrayOfStrings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 100));
            FindTheLongestStringInArray(arrayOfStrings);
        }

        private static void FindTheLongestStringInArray(string[] array)
        {
            Console.WriteLine("The longest string in the array is:");

            var longestString = array.Where(str => str.Length == array.Max(m => m.Length)).First();

            Console.WriteLine(longestString);
            Console.WriteLine("Number of characters: {0}", longestString.Length);
        }

        private static char[] Letters()
        {
            char[] letters = new char[28];
            letters[0] = ' ';
            for (int i = 1; i < letters.Length; i++)
            {
                letters[i] = (char)(i + 96);
            }
            letters[27] = ' ';

            return letters;
        }

        private static string[] RandomStringGenerator()
        {
            Random rnd = new Random();

            string[] array = new string[rnd.Next(10, 21)];
            char[] letters = Letters();

            var currentString = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                int randomLength = rnd.Next(1, 101);
                for (int j = 0; j < randomLength; j++)
                {
                    currentString.Append(letters[rnd.Next(0, letters.Length)]);
                }

                array[i] = currentString.ToString().Trim();
                currentString.Clear();
            }

            return array;
        }
    }
}