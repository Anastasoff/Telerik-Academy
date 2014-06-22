/*
2. Define abstract class Human with first name and last name. 
Define new class Student which is derived from Human and has new field – grade. 
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
and method MoneyPerHour() that returns money earned by hour by the worker. 
Define the proper constructors and properties for this hierarchy. 
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/

namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestHuman
    {
        public static void Main()
        {
            List<Student> students = new List<Student> 
            {
                new Student("Ivo", "Georgiev", 11),
                new Student("Ivan", "Petrov", 2),
                new Student("Drago", "Vasilev", 1),
                new Student("Stefan", "Ivanov", 7),
                new Student("Ivo", "Soqnov", 9),
                new Student("Boiko", "Boriosv", 6),
                new Student("Vasil", "Iliev", 12),
                new Student("Atanas", "Djambazov", 8),
                new Student("Mitko", "Todorov", 5),
                new Student("Atanas", "Kazandjiev", 5)
            };

            var orderByGrade = students.OrderBy(x => x.Grade).ThenBy(x => x.FirstName);
            foreach (Student student in orderByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n{0}\n", new string('*', 50));

            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Peshev", 123.60, 8),
                new Worker("Pesho", "Ivanov", 170.10, 13),
                new Worker("Mitko", "Petkov", 145, 8),
                new Worker("Strahil", "Ivanov", 201.49, 10),
                new Worker("Dimitar", "Kolev", 121.60, 6),
                new Worker("Ivan", "Nikolaev", 150.65, 8),
                new Worker("Nikolai", "Ivanov", 183.70, 9),
                new Worker("Krasi", "Ivanov", 90.60, 8),
                new Worker("Joro", "Krasimirov", 303.90, 14),
                new Worker("Asencho", "Asenov", 103.60, 5)
            };

            var orderByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (Worker worker in orderByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("\n{0}\n", new string('=', 60));

            List<Human> merged = new List<Human>(students.Count + workers.Count);
            merged.AddRange(students);
            merged.AddRange(workers);
            var orderByName =
                from human in merged
                orderby human.FirstName, human.LastName
                select human;
            foreach (Human person in orderByName)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }

            Console.WriteLine("\n-= The End =-\n");
        }
    }
}
