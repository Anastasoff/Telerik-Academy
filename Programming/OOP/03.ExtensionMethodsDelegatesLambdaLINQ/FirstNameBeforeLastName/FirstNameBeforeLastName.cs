// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
//      Use LINQ query operators.

namespace FirstNameBeforeLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FirstNameBeforeLastName
    {
        public static void Main()
        {
            Student[] students = 
            {
                new Student("Pesho", "Georgiev"),
                new Student("Gosho", "Peshev"),
                new Student("Atanas", "Tanasev"),
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
