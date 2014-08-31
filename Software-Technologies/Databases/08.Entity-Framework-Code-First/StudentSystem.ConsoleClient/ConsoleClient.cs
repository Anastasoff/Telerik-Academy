namespace StudentSystem.ConsoleClient
{
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System;
    using System.Linq;

    internal class ConsoleClient
    {
        private static StudentSystemDbContext db;

        public static void Main()
        {
            InitDbContext();

            Console.WriteLine("Insert: ({0} row(s) affected)", InsertNewStudent());

            var student = SelectStudentByID(1);
            Console.WriteLine("Select: {0} {1}", student, student.DateAdded);
        }

        private static void InitDbContext()
        {
            db = new StudentSystemDbContext();
        }

        public static int InsertNewStudent()
        {
            Student pesho = new Student()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                DateOfBirth = new DateTime(1999, 01, 01),
                DateAdded = DateTime.Now
            };

            db.Students.Add(pesho);

            Student gosho = new Student()
            {
                FirstName = "Gosho",
                LastName = "Goshov",
                DateOfBirth = new DateTime(1989, 08, 10),
                DateAdded = DateTime.Now
            };

            db.Students.Add(gosho);

            return db.SaveChanges();
        }

        public static Student SelectStudentByID(int studentID)
        {
            var student = db.Students.FirstOrDefault(st => st.StudentID == studentID);

            return student;
        }
    }
}