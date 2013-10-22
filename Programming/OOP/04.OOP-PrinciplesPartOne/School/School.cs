namespace School
{
    using System.Collections.Generic;

    public class School
    {
        private List<SchoolClass> classesOfStudents;

        public School(SchoolClass[] classessOfStudents)
        {
            this.classesOfStudents = new List<SchoolClass>();
        }

        public SchoolClass[] ClassesOfStudents
        {
            get { return this.classesOfStudents.ToArray(); }
            private set { }
        }

        public void AddClass(SchoolClass classOfStudents)
        {
            this.classesOfStudents.Add(classOfStudents);
        }

        public void RemoveClass(SchoolClass classOfStudents)
        {
            this.classesOfStudents.Remove(classOfStudents);
        }
    }
}
