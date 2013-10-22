namespace School
{
    public class Discipline : ICommentable
    {
        private string comment;

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }        

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
