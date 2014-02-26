// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//      Use LINQ query operators.

namespace FirstNameBeforeLastName
{
    using System;
    using System.Linq;

    public class FirstNameBeforeLastName
    {
        public static void Main()
        {
            Student[] students =
            {
                new Student("Pesho", "Peshev"),
                new Student("Gosho", "Georgiev"),
                new Student("Haralampi", "Popov"),
                new Student("Atanas", "Atanasov")
            };

            // Filter inputArray = new Filter(students);
            // inputArray.OrderBy();

            var firstBeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}