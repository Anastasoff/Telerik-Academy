namespace ToListProblem
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using TelerikAcademy.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            TelerikAcademyDbContext db = new TelerikAcademyDbContext();

            using (db)
            {
                SelectWithToListProblem(db);

                Console.WriteLine();

                SelectWithoutToListProblem(db);
            }
        }

        public static void SelectWithToListProblem(TelerikAcademyDbContext db)
        {
            var sw = Stopwatch.StartNew();

            var query = db.Employees.ToList()
                .Select(employee => employee.Address).ToList()
                .Select(address => address.Town).ToList()
                .Where(town => town.Name == "Sofia");
            int i = 1;
            foreach (var town in query)
            {
                Console.WriteLine(i++ + ". " + town.Name);
            }

            sw.Stop();
            Console.WriteLine("With ToList(): {0}", sw.Elapsed);
        }

        public static void SelectWithoutToListProblem(TelerikAcademyDbContext db)
        {
            var sw = Stopwatch.StartNew();
            var query = db.Employees
                .Select(employee => employee.Address)
                .Select(address => address.Town)
                .Where(town => town.Name == "Sofia");
            int i = 1;
            foreach (var town in query)
            {
                Console.WriteLine(i++ + ". " + town.Name);
            }

            sw.Stop();
            Console.WriteLine("Without ToList(): {0}", sw.Elapsed);
        }
    }
}