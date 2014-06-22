namespace Human
{
    using System;

    public abstract class Human : IPerson
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 2)
                {
                    throw new ArgumentException("Invalid first name!");
                }

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
                if (string.IsNullOrEmpty(value) || value.Length <= 2)
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }
    }
}