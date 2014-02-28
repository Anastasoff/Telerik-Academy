namespace GroupNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Tester
    {
        private static void Main()
        {
            var students = new Student[]
            {
                new Student("Pesho", "Peshev", "Maths"),
                new Student("Gosho", "Goshev", "Biology"),
                new Student("Atanas", "Atanasov", "Law"),
                new Student("Mitko", "Dimitrov", "Maths"),
                new Student("Kosta", "Kostov", "ComputerScience"),
                new Student("Grigor", "Grigorov", "Law"),
                new Student("Vesko", "Vasilov", "Law"),
                new Student("Ivan", "Ivanov", "ComputerScience")
            };

            GroupedByGroupNameLinq(students);
            GroupedByGroupNameLambda(students);
        }

        /// <summary>
        /// 18. Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void GroupedByGroupNameLinq(ICollection<Student> students)
        {
            Console.WriteLine("Method: {0}", MethodInfo.GetCurrentMethod().Name);

            var result =
                from student in students
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var group in result)
            {
                Console.WriteLine("GroupName: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("- {0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Rewrite the previous using extension methods.
        /// </summary>
        /// <param name="students">Collection of students</param>
        private static void GroupedByGroupNameLambda(ICollection<Student> students)
        {
            Console.WriteLine("Method: {0}", MethodInfo.GetCurrentMethod().Name);

            var result = students.GroupBy(x => x.GroupName).OrderBy(x => x.Key);

            foreach (var group in result)
            {
                Console.WriteLine("GroupName: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("- {0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
        }
    }
}