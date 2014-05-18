namespace Minesweeper
{
    public class Result
    {
        #region Private Fields

        private string name = string.Empty;

        private int score = 0;

        #endregion Private Fields

        #region Constructors

        public Result()
        {
        }

        public Result(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        #endregion Constructors

        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                this.score = value;
            }
        }

        #endregion Properties
    }
}