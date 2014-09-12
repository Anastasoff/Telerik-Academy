namespace AcademyTasks
{
    using System;
    using System.Collections.Generic;

    public class AcademyTasks
    {
        private static int[] pleasantness;
        private static int variety;

        public static void Main()
        {
            ProcessInput();

            Console.WriteLine(2);
        }

        private static void ProcessInput()
        {
            string[] listOfNumbersInPleasantness = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int length = listOfNumbersInPleasantness.Length;
            pleasantness = new int[length];
            for (int i = 0; i < length; i++)
            {
                pleasantness[i] = int.Parse(listOfNumbersInPleasantness[i]);
            }

            variety = int.Parse(Console.ReadLine());
        }

        private static void SolveTasks(int index)
        {
            if (index >= pleasantness.Length)
            {
                return;
            }

            for (int i = 0; i < pleasantness.Length; i++)
            {

            }
        }
    }
}