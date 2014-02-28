namespace Students
{
    using System.Collections.Generic;

    public class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName, string fn, string tel, string email, ICollection<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, string fn, string tel, string email, ICollection<int> marks, int groupNumber, Group group)
            : this(firstName, lastName, fn, tel, email, marks, groupNumber)
        {
            this.Group = group;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public ICollection<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - FN: {2}, Tel: {3}, Email: {4}, Marks: {5}, GroupNumber: {6};", this.FirstName, this.LastName, this.FN, this.Tel, this.Email, string.Join(", ", this.Marks), this.GroupNumber);
        }
    }
}