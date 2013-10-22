namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : ICommentable
    {
        private string textID;
        private string comment;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string textID, Student[] students, Teacher[] teachers)
        {
            this.textID = textID;
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
        }

        public string TextID
        {
            get 
            { 
                return this.textID; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid text identifier!");
                }

                this.textID = value;
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public Student[] Students
        {
            get { return this.students.ToArray(); }
            private set { }
        }

        public Teacher[] Teachers
        {
            get { return this.teachers.ToArray(); }
            private set { }
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
    }
}
