namespace School
{
    using System;

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 2)
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }
    }
}
