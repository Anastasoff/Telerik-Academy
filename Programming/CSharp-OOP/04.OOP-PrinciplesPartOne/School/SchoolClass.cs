namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : ICommentable
    {
        private string textID;
        private string comment;
        private ICollection<Student> students;
        private ICollection<Teacher> teachers;

        public SchoolClass(string textID, ICollection<Student> students, ICollection<Teacher> teachers)
        {
            this.TextID = textID;
            this.Students = new List<Student>(students);
            this.Teachers = new List<Teacher>(teachers);
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
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                this.students = value;
            }
        }

        public ICollection<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            private set
            {
                this.teachers = value;
            }
        }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
    }
}