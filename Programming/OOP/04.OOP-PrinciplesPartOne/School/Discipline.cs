namespace School
{
    public class Discipline : ICommentable
    {
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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

        public string Name { get; set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}