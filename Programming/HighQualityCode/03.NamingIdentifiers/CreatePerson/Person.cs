namespace CreatePerson
{
    using System;

    internal class Person
    {
        public Person(string name, int? age, Gender gender)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null or empty.");
            }

            if (age <= 0)
            {
                throw new ArgumentException("age must be positive.");
            }

            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
            : this(string.Empty, null, Gender.Unknown)
        {
        }

        public string Name { get; private set; }

        public int? Age { get; private set; }

        public Gender Gender { get; private set; }

        public override string ToString()
        {
            return string.Format(
                "Name: {0}, Age: {1}, Gender: {2}",
                string.IsNullOrWhiteSpace(this.Name) ? "[no name specified]" : this.Name,
                this.Age.HasValue ? this.Age.ToString() : "[no age specified]",
                this.Gender);
        }
    }
}