namespace AcademyTasks
{
    using System;

    public class AcademyTasks
    {
        private static int[] pleasantness;
        private static int variety;
        private static int minSolvedProblems;

        public static void Main()
        {
            ProcessInput();

            minSolvedProblems = pleasantness.Length;

            SolveTasks(0, pleasantness[0], pleasantness[0], 1);

            Console.WriteLine(minSolvedProblems);
        }

        private static void ProcessInput()
        {
            string[] listOfNumbersInPleasantness = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int length = listOfNumbersInPleasantness.Length;
            pleasantness = new int[length];
            for (int i = 0; i < length; i++)
            {
                pleasantness[i] = int.Parse(listOfNumbersInPleasantness[i]);
            }

            variety = int.Parse(Console.ReadLine());
        }

        private static void SolveTasks(int index, int min, int max, int solvedProblems)
        {
            if (max - min >= variety)
            {
                minSolvedProblems = Math.Min(minSolvedProblems, solvedProblems);
                return;
            }

            if (index >= pleasantness.Length)
            {
                return;
            }

            for (int i = 1; i <= 2; i++)
            {
                int currentIndex = index + i;
                if (currentIndex < pleasantness.Length)
                {
                    int currentMin = Math.Min(min, pleasantness[currentIndex]);
                    int currentMax = Math.Max(max, pleasantness[currentIndex]);
                    SolveTasks(currentIndex, currentMin, currentMax, solvedProblems + 1);
                }
            }
        }
    }
}