namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    internal class Tester
    {
        /// <summary>
        /// 9 Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students.
        /// </summary>
        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Grigor", "Petrov", "316104", "02876455", "grigor@abv.bg", new List<int> { 3, 4 }, 2, new Group(15, "Physics")),
                new Student("Petar", "Marinov", "316206", "02899123", "petar@gmail.com", new List<int> { 6, 5, 6, 6 }, 2, new Group(3, "Mathematics")),
                new Student("Dobri", "Gospodinov", "324806", "73654789", "dobri@abv.bg", new List<int> { 6, 5, 6 }, 4, new Group(9, "Medicine")),
                new Student("Anna", "Dimova", "395103", "52999999", "anna@gmail.com", new List<int> { 6, 6, 2 }, 2, new Group(11, "Mathematics")),
                new Student("Penka", "Stoicheva", "318206", "0899111111", "penka@abv.bg", new List<int> { 2, 2, 3, 3 }, 5, new Group(22, "Mathematics")),
                new Student("Anna", "Dimova", "395103", "52999999", "anna@gmail.com", new List<int> { 2, 2, 3, 3, 4 }, 1, new Group(11, "Chemistry"))
            };

            SelectStudentsByGroupWithLinq(students);
            SelectStudentsByGroupWithLambda(students);
            ExtractStudentsByEmail(students);
            ExtractStudentsByPhone(students);
            SelectStudentsByMarksWithLinq(students);
            SelectStudentsByMarksWithLambda(students);
            ExtractStudentsByFN(students);
            ExtractStudentsByDepartment(students);
        }

        private static void PrintStudents<T>(IEnumerable<T> students)
        {
            Console.WriteLine("Method: {0}:", new StackFrame(1).GetMethod().Name);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 9.1 Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
        /// </summary>
        /// <param name="students">Collection of students.</param>
        private static void SelectStudentsByGroupWithLinq(IEnumerable<Student> students)
        {
            int groupNumber = 2;
            var result =
                from student in students
                where student.GroupNumber == groupNumber
                orderby student.FirstName
                select student;

            PrintStudents(result);
        }

        /// <summary>
        /// 10. Implement the previous using the same query expressed with extension methods.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void SelectStudentsByGroupWithLambda(IEnumerable<Student> students)
        {
            int groupNumber = 2;
            var result = students.Where(st => st.GroupNumber == groupNumber).OrderBy(st => st.FirstName);
            PrintStudents(result);
        }

        /// <summary>
        /// 11. Extract all students that have email in abv.bg. Use string methods and LINQ.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void ExtractStudentsByEmail(IEnumerable<Student> students)
        {
            string email = "@abv.bg";
            var result =
                from student in students
                where student.Email.Contains(email)
                select student;

            PrintStudents(result);
        }

        /// <summary>
        /// 12. Extract all students with phones in Sofia. Use LINQ.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void ExtractStudentsByPhone(IEnumerable<Student> students)
        {
            string phoneCode = "02";
            var result =
                from student in students
                where student.Tel.Substring(0, 2) == phoneCode
                select student;

            PrintStudents(result);
        }

        /// <summary>
        /// 13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
        /// </summary>
        private static void SelectStudentsByMarksWithLinq(IEnumerable<Student> students)
        {
            Console.WriteLine("Method: {0}:", MethodInfo.GetCurrentMethod().Name);

            int mark = 6;
            var result =
                from student in students
                where student.Marks.Contains(mark)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in result)
            {
                Console.WriteLine("{0} - Marks: {1};", student.FullName, string.Join(", ", student.Marks));
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 14. Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void SelectStudentsByMarksWithLambda(IEnumerable<Student> students)
        {
            Console.WriteLine("Method: {0}:", MethodInfo.GetCurrentMethod().Name);
            int mark = 2;
            var result = students.Where(st => st.Marks.Count(m => m == mark) == 2).Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks });

            foreach (var student in result)
            {
                Console.WriteLine("{0} - Marks: {1};", student.FullName, string.Join(", ", student.Marks));
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 15. Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void ExtractStudentsByFN(IEnumerable<Student> students)
        {
            string year = "06";
            var resultWithLinq =
                from student in students
                where student.FN.Substring(4) == year
                select student;

            var resultWithLambda = students.Where(st => st.FN.Substring(4) == year);

            Action<IEnumerable<Student>> result = PrintStudents;
            result(resultWithLinq);
            result(resultWithLambda);
        }

        /// <summary>
        /// * Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group in the Student class.
        /// Extract all students from "Mathematics" department. Use the Join operator.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void ExtractStudentsByDepartment(IEnumerable<Student> students)
        {
            Group[] groups = new Group[]
            {
                new Group(15, "Mathematics"),
                new Group(11, "Medicine"),
                new Group(3, "Physics"),
                new Group(1, "Chemistry")
            };

            string department = "Mathematics";
            var result =
                from gr in groups
                join st in students on gr.DepartmentName equals st.Group.DepartmentName
                where gr.DepartmentName == department
                select new { FullName = st.FirstName + " " + st.LastName, Department = st.Group.DepartmentName };

            foreach (var student in result)
            {
                Console.WriteLine("{0}, Department: {1};", student.FullName, student.Department);
            }
        }
    }
}