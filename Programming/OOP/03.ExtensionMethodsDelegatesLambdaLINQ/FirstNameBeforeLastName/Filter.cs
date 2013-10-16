namespace FirstNameBeforeLastName
{
    using System;
    using System.Linq;

    public class Filter
    {
        private Student[] inputArray;

        public Filter(Student[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public Student[] InputArray
        {
            set
            {
                this.inputArray = value;
            }
        }

        public void OrderBy()
        {
            var firstBeforeLast =
                from student in this.inputArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
