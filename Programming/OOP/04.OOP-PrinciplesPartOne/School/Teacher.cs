namespace School
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        private string comment;
        private ICollection<Discipline> disciplines;

        public Teacher(string name, ICollection<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = new List<Discipline>(disciplines);
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            private set
            {
                this.comment = value;
            }
        }

        public ICollection<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            private set
            {
                this.disciplines = value;
            }
        }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}