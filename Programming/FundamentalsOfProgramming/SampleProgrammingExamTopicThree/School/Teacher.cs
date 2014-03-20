namespace School
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Group> Group { get; set; }

        public Teacher(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Group = new List<Group>();
        }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public override string ToString()
        {
            StringBuilder teacherAsString = new StringBuilder();
            teacherAsString.AppendLine("Teacher name: " + this.Name);
            teacherAsString.AppendLine("Group of this teacher: " + string.Join(", ", this.Group.Select(s => s.Name)));

            return teacherAsString.ToString();
        }
    }
}
