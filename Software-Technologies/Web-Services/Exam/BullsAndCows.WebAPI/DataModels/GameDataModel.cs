namespace Project.WebAPI.DataModels
{
    using BullsAndCows.Models;
    using System;
    using System.Linq.Expressions;

    public class GameDataModel
    {
        public static Expression<Func<Game, GameDataModel>> FromGuess
        {
            get
            {
                return g => new GameDataModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    DateCreated = g.DateCreated,
                    Red = g.Red.UserName,
                    Blue = g.Blue.UserName,
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string Blue { get; set; }

        public string Red { get; set; }

        public GameState GameState { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}