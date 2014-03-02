namespace Student
{
    using System;

    public class Tester
    {
        public static void Main()
        {
            Student firstStudent = new Student("Pesho", "Peshev", "Peshev", "987-65-4329", "Sofia", "+359888123456",
                "email@peshev.com", 2, University.SofiaUniversity, Faculty.MathematicsAndInformaticsFaculty, Specialty.ComputerScience);
            Console.WriteLine(firstStudent);

            Student secondStudent = new Student("Pesho", "Peshev", "Peshev", "987-65-4329", "Plovdiv", "+359999123456",
                "email@peshev.com", 2, University.UNWE, Faculty.MarketingFaculty, Specialty.Iconomics);
            Console.WriteLine(secondStudent);

            Console.WriteLine("FirstStudent == SecondStudent ? ==> {0}", firstStudent == secondStudent);
            Console.WriteLine("SecondStudent equals FirstStudent ? ==> {0}", secondStudent.Equals(firstStudent));

            Student firstStudentClone = firstStudent.Clone() as Student;
            firstStudent.LastName = "Pantaleeff";

            Console.WriteLine("Change FirstStudent.LastName to 'Pantaleeff'");

            Console.WriteLine("FirstStudent == SecondStudent ? ==> {0}", firstStudent == firstStudentClone);

            Console.WriteLine("Comparing FirstStudent with SecondStudent ? ==> {0}", firstStudentClone.CompareTo(firstStudent));
        }
    }
}