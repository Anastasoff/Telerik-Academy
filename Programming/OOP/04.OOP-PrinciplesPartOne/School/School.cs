namespace School
{
    using System.Collections.Generic;

    public class School
    {
        private ICollection<SchoolClass> classesOfStudents;

        public School(ICollection<SchoolClass> classessOfStudents)
        {
            this.ClassesOfStudents = new List<SchoolClass>(classessOfStudents);
        }

        public ICollection<SchoolClass> ClassesOfStudents
        {
            get
            {
                return this.classesOfStudents;
            }

            private set
            {
                this.classesOfStudents = value;
            }
        }

        public void AddClass(SchoolClass classOfStudents)
        {
            this.ClassesOfStudents.Add(classOfStudents);
        }

        public void RemoveClass(SchoolClass classOfStudents)
        {
            this.ClassesOfStudents.Remove(classOfStudents);
        }
    }
}