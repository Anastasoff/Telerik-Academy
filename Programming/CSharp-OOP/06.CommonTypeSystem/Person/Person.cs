namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private byte? age;

        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Name's length is greater than 50 characters!");
                }

                this.name = value;
            }
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.age > 120)
                {
                    throw new ArgumentOutOfRangeException("Invalid age range [0 ... 120].");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, age: {1}", this.Name, this.Age == null ? "[unknown age]" : this.Age.ToString());
        }
    }
}
