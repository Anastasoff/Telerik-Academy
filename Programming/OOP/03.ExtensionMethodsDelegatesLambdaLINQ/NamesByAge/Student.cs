namespace NamesByAge
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} => age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
