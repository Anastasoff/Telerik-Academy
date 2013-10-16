// 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace NamesByAge
{
    using System;
    using System.Linq;

    public class NamesByAge
    {
        public static void Main()
        {
            Student[] students = 
            {
                new Student("Pesho", "Georgiev", 16),
                new Student("Gosho", "Peshev", 19),
                new Student("Atanas", "Tanasev", 22),
                new Student("Atanas", "Atanasov", 30)
            };

            var filterByAge =
                from student in students
                where (student.Age >= 18) && (student.Age <= 24)
                select student;

            foreach (var student in filterByAge)
            {
                Console.WriteLine(student.ToString());
            }

            // -------------------
            // UseAnnonymousTypes();
        }

        public static void UseAnnonymousTypes()
        {
            var students = new[]
            {
                new {FirstName = "Pesho", LastName = "Georgiev", Age = 16},
                new {FirstName = "Gosho", LastName = "Peshev", Age = 19},
                new {FirstName = "Atanas", LastName = "Tanasov", Age = 22},
                new {FirstName = "Atanas", LastName = "Atanasov", Age = 30}
            };

            var filterByAge =
                from student in students
                where (student.Age >= 18) && (student.Age <= 24)
                select student;

            foreach (var student in filterByAge)
            {
                Console.WriteLine("{0} {1} => age: {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
