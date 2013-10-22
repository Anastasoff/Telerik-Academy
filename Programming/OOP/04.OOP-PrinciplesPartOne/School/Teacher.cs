namespace School
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        private string comment;
        private List<Discipline> disciplines;

        public Teacher(string name, Discipline[] disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>(disciplines);
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

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }
    }
}
