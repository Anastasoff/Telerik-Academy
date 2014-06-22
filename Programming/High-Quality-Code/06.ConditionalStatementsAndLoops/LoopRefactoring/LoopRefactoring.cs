namespace LoopRefactoring
{
    using System;
    using System.Text;

    public class LoopRefactoring
    {
        public static void Main()
        {
            int arrayLength = ConsoleInput();
            int[] array = GenerateRandomIntArray(arrayLength);

            int expectedValue = 666;
            bool isFound = false;
            StringBuilder numbersInArray = new StringBuilder();
            for (int i = 0; i < arrayLength; i++)
            {
                numbersInArray.AppendLine(array[i].ToString());
                if ((i % 10 == 0) && (array[i] == expectedValue))
                {
                    isFound = true;
                    break;
                }
            }

            Console.WriteLine(numbersInArray);
            ConsoleOutput(isFound);
        }

        private static int ConsoleInput()
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            return arrayLength;
        }

        private static void ConsoleOutput(bool isFound)
        {
            if (isFound)
            {
                Console.WriteLine("Value is found!");
            }
            else
            {
                Console.WriteLine("Value is not found!");
            }
        }

        private static int[] GenerateRandomIntArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(1, 1001);
            }

            return array;
        }
    }
}