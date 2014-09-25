namespace BullsAndCows.Models
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        private ICollection<Guess> guesses;

        public Game()
        {
            this.guesses = new HashSet<Guess>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public GameState GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public string BlueId { get; set; }

        public virtual User Blue { get; set; }

        public string RedId { get; set; }

        public virtual User Red { get; set; }

        public virtual ICollection<Guess> Guesses
        {
            get
            {
                return this.guesses;
            }

            set
            {
                this.guesses = value;
            }
        }
    }
}