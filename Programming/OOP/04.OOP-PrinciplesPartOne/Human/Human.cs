namespace Human
{
    public abstract class Human : IPerson
    {
        private string firstName;
        private string lastName;

        //protected Human(string firstName, string lastName)
        //{
        //    if (string.IsNullOrEmpty(firstName) || firstName.Length < 2)
        //    {
        //        throw new ArgumentException("Invalid first name!");
        //    }

        //    this.firstName = firstName;

        //    if (string.IsNullOrEmpty(lastName) || lastName.Length < 2)
        //    {
        //        throw new ArgumentException("Invalid last name!");
        //    }

        //    this.lastName = lastName;
        //}

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                //if (string.IsNullOrEmpty(firstName) || firstName.Length < 2)
                //{
                //    throw new ArgumentException("Invalid first name!");
                //}

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                //if (string.IsNullOrEmpty(lastName) || lastName.Length < 2)
                //{
                //    throw new ArgumentException("Invalid last name!");
                //}

                this.lastName = value;
            }
        }
    }
}
