namespace Salaries
{
    using System;

    public class Program
    {
        private static int c;
        private static bool[,] hierarchy;
        private static long[] salaries;

        public static void Main()
        {
            ProcessInput();

            for (int i = 0; i < c; i++)
            {
                if (salaries[i] == 0)
                {
                    CalculateSalary(i);
                }
            }

            long totalSum = 0L;
            for (int i = 0; i < c; i++)
            {
                totalSum += salaries[i];
            }

            Console.WriteLine(totalSum);
        }

        private static void ProcessInput()
        {
            c = int.Parse(Console.ReadLine());
            hierarchy = new bool[c, c];
            salaries = new long[c];

            for (int i = 0; i < c; i++)
            {
                string employees = Console.ReadLine();
                for (int j = 0; j < employees.Length; j++)
                {
                    if (employees[j] == 'Y')
                    {
                        hierarchy[i, j] = true;
                    }
                }
            }
        }

        private static void CalculateSalary(int employee)
        {
            bool hasSubordinates = false;

            for (int i = 0; i < c; i++)
            {
                if (hierarchy[employee, i])
                {
                    hasSubordinates = true;
                    if (salaries[i] == 0)
                    {
                        CalculateSalary(i);
                    }

                    salaries[employee] += salaries[i];
                }
            }

            if (!hasSubordinates)
            {
                salaries[employee] = 1;
            }
        }
    }
}