namespace Company.ConsoleClient
{
    using Company.Generator;

    internal class Program
    {
        private const int DepartmentsCount = 100;

        private static void Main(string[] args)
        {
            DepartmentsGenerator.Generate(DepartmentsCount);
        }
    }
}