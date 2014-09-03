namespace StudentsInCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class StudentsInCourses
    {
        private static void Main(string[] args)
        {
            string filePath = "../.../students.txt";
            var courses = new SortedDictionary<string, List<Student>>();
            foreach (string line in File.ReadLines(filePath))
            {
                var fields = line.Split('|')
                    .Select(s => s.Trim())
                    .ToArray();
                var fname = fields[0];
                var lname = fields[1];
                var course = fields[2];

                List<Student> students;
                if (!courses.TryGetValue(course, out students))
                {
                    students = new List<Student>();
                    courses.Add(course, students);
                }

                var student = new Student()
                {
                    FirstName = fname,
                    LastName = lname
                };
                students.Add(student);
            }
            foreach (var course in courses)
            {
                var orderedStr = course.Value.OrderBy(s => s.LastName).ThenBy(s => s.FirstName);
                string formatedStr = string.Format("{0}: {1}", course.Key, string.Join(", ", orderedStr));
                Console.WriteLine(formatedStr);
            }
        }
    }
}