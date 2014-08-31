namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            this.SeedCourses(context);
            this.SeedStudents(context);
        }

        private void SeedStudents(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
            {
                FirstName = "Evlogi",
                LastName = "Hristov",
                DateOfBirth = new DateTime(1985, 02, 12),
                DateAdded = DateTime.Now
            });

            context.Students.Add(new Student
            {
                FirstName = "Ivaylo",
                LastName = "Kenov",
                DateOfBirth = new DateTime(1989, 05, 01),
                DateAdded = DateTime.Now
            });

            context.Students.Add(new Student
            {
                FirstName = "Doncho",
                LastName = "Minkov",
                DateOfBirth = new DateTime(1988, 11, 22),
                DateAdded = DateTime.Now
            });

            context.Students.Add(new Student
            {
                FirstName = "Nikolay",
                LastName = "Kostov",
                DateOfBirth = new DateTime(1990, 01, 20),
                DateAdded = DateTime.Now
            });
        }

        private void SeedCourses(StudentSystemDbContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.Add(new Course
            {
                Name = "Seeded course",
                Description = "Initial course for testing"
            });
        }

        private void SeedHomeworks(StudentSystemDbContext context)
        {
            if (context.Homeworks.Any())
            {
                return;
            }

            context.Homeworks.Add(new Homework
            {
                FileName = "Entity-Framework.rar",
                TimeSent = DateTime.Now
            });

            context.Homeworks.Add(new Homework
            {
                FileName = "Entity-Framework-Code-First.rar",
                TimeSent = DateTime.Now
            });
        }
    }
}