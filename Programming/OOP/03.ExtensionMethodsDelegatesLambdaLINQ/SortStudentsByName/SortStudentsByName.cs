// 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

namespace SortStudentsByName
{
    using System;
    using System.Linq;

    public class SortStudentsByName
    {
        public static void Main()
        {
            var students = new[]
            {
                new {FirstName = "Pesho", LastName = "Georgiev"},
                new {FirstName = "Gosho", LastName = "Peshev"},
                new {FirstName = "Atanas", LastName = "Tanasov"},
                new {FirstName = "Atanas", LastName = "Atanasov"}
            };

            Console.WriteLine("Sorted with Lambda expression:\n");
            students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("\nSorted with LINQ:\n");
            var orderByName =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
