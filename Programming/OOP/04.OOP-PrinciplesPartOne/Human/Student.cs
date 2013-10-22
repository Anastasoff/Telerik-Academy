namespace Human
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
        // : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }

        public int Grade
        {
            get 
            { 
                return this.grade; 
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The grade starts from 1.");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, grade: {2};", this.FirstName, this.LastName, this.grade);
        }
    }
}
