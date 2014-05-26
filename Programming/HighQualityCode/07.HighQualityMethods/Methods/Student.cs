namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string occupation;

        public Student()
        {
            this.firstName = null;
            this.lastName = null;
            this.age = 0;
            this.occupation = null;
        }

        public Student(string firstName, string lastName, int age, string occupation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Occupation = occupation;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                ChechStringInput(value, "FirstName");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                ChechStringInput(value, "LastName");

                this.lastName = value;
            }
        }

        // TODO: implement DateOfBorn

        public int Age
        {
            get
            {
                // TODO: implement date of born parser to extract student's age
                return this.age;
            }

            set
            {
                // TODO: remove setter after implement DateOfBorn
                if (value <= 0 || value >= 150)
                {
                    throw new ArgumentException("The input value of Age is not in the range [1 ... 150]");
                }

                this.age = value;
            }
        }

        public string Occupation
        {
            get
            {
                return this.occupation;
            }

            set
            {
                ChechStringInput(value, "Occupation");

                this.occupation = value;
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            if (otherStudent == null)
            {
                throw new NullReferenceException("The other student is null.");
            }

            // TODO: implement comparison by date of born.
            bool isOlderThanOther = false;
            if (this.Age > otherStudent.Age)
            {
                return true;
            }

            return isOlderThanOther;
        }

        private void ChechStringInput(string inputValue, string fieldName)
        {
            if (inputValue == null)
            {
                throw new NullReferenceException(string.Format("The input value of {0} is null.", fieldName));
            }

            if (string.IsNullOrWhiteSpace(inputValue))
            {
                throw new ArgumentException(string.Format("The input value of {0} is empty or white space.", fieldName));
            }
        }
    }
}