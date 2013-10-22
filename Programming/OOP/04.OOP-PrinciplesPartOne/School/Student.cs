namespace School
{
    using System;

    public class Student : Person, ICommentable
    {
        private int classNumber;
        private string comment;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get 
            { 
                return this.classNumber; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The unique class number cannot be less than zero");
                }

                this.classNumber = value;
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }
    }
}
