namespace Nplus1Problem
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using TelerikAcademy.Models;

    public class Program
    {
        public static void Main()
        {
            TelerikAcademyDbContext db = new TelerikAcademyDbContext();

            using (db)
            {
                // First time always will be slower because of connection things :)
                SelectAllEmployeesFromDbWithProblem(db);

                Console.WriteLine();

                SelectAllEmployeesFromDbWithInclude(db);

                Console.WriteLine();

                SelectAllEmployeesFromDbWithoProjection(db);

                Console.WriteLine();

                SelectAllEmployeesFromDbWithProblem(db);
            }
        }

        public static void SelectAllEmployeesFromDbWithProblem(TelerikAcademyDbContext db)
        {
            int i = 0;
            var sw = Stopwatch.StartNew();
            foreach (var empl in db.Employees)
            {
                string name = empl.FirstName + " " + empl.LastName;
                string department = empl.Department.Name;
                string town = empl.Address.Town.Name;

                // Console.WriteLine("{0}. {1}, {2}, {3}", i++, name, department, town);
            }

            sw.Stop();
            Console.WriteLine("With N+1 Problem: {0}", sw.Elapsed);
        }

        public static void SelectAllEmployeesFromDbWithInclude(TelerikAcademyDbContext db)
        {
            int i = 0;
            var sw = Stopwatch.StartNew();
            var query = db.Employees
                .Include("Department")
                .Include("Address.Town");
            foreach (var empl in query)
            {
                string name = empl.FirstName + " " + empl.LastName;
                string department = empl.Department.Name;
                string town = empl.Address.Town.Name;

                // Console.WriteLine("{0}. {1}, {2}, {3}", i++, name, department, town);
            }

            sw.Stop();
            Console.WriteLine("With Include: {0}", sw.Elapsed);
        }

        public static void SelectAllEmployeesFromDbWithoProjection(TelerikAcademyDbContext db)
        {
            int i = 0;
            var sw = Stopwatch.StartNew();
            var query = db.Employees
                .Select(empl => new
                {
                    FullName = empl.FirstName + " " + empl.LastName,
                    DepartmentName = empl.Department.Name,
                    TownName = empl.Address.Town.Name
                });
            foreach (var empl in query)
            {
                string name = empl.FullName;
                string department = empl.DepartmentName;
                string town = empl.TownName;

                // Console.WriteLine("{0}. {1}, {2}, {3}", i++, name, department, town);
            }

            sw.Stop();
            Console.WriteLine("With Projection: {0}", sw.Elapsed);
        }
    }
}