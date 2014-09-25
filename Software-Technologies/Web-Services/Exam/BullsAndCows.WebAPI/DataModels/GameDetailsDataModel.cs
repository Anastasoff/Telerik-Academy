namespace Project.WebAPI.DataModels
{
    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GameDetailsDataModel
    {
        public GameDetailsDataModel(Game game, IBullsAndCowsData data)
        {
            this.Id = game.Id;
            this.Name = game.Name;
            this.DateCreated = game.DateCreated;
            this.Red = game.Red.UserName;
            this.Blue = game.Blue.UserName;
            this.YourNumber = game.Red.UserName;
            this.YourGuesses = data.Guesses.All().Where(u => u.UserId == game.Red.Id).Select(GuessDataModel.FromGuess).ToList();
            this.OpponentGuesses = data.Guesses.All().Where(u => u.UserId == game.Blue.Id).Select(GuessDataModel.FromGuess).ToList();
            this.YourColor = "red";
            this.GameState = game.GameState;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public string Red { get; set; }

        public string Blue { get; set; }

        public string YourNumber { get; set; }

        public ICollection<GuessDataModel> YourGuesses { get; set; }

        public ICollection<GuessDataModel> OpponentGuesses { get; set; }

        public string YourColor { get; set; }

        public GameState GameState { get; set; }
    }
}