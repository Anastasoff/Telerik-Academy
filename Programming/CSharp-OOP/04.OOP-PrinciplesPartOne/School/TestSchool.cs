/*
1. We are given a school. In the school there are classes of students. 
Each class has a set of teachers. Each teacher teaches a set of disciplines. 
Students have name and unique class number. Classes have unique text identifier. 
Teachers have name. Disciplines have name, number of lectures and number of exercises. 
Both teachers and students are people. 
Students, classes, teachers and disciplines could have optional comments (free text block).

Your task is to identify the classes (in terms of  OOP) and their attributes and operations, 
encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace School
{
    public class TestSchool
    {
        public static void Main()
        {
            Student firstStudent = new Student("Pesho Peshev", 123456);
            Student secondStudent = new Student("Gosho Goshev", 456789);
            Student thirdStudent = new Student("Ivancho Ivanchev", 789123);
            Student[] students = new Student[] { firstStudent, secondStudent, thirdStudent };

            Discipline csharp = new Discipline("C# Fundamentals", 17, 142);
            Discipline oop = new Discipline("Object-Oriented Programming", 8, 29);
            Discipline[] disciplines = new Discipline[] { csharp, oop };

            Teacher teacher = new Teacher("Svetlin Nakov", disciplines);
            Teacher[] teachers = new Teacher[] { teacher };

            SchoolClass firstClass = new SchoolClass("Spring Academy", students, teachers);
        }
    }
}
