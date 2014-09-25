namespace Project.WebAPI.Controllers
{
    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using Microsoft.AspNet.Identity;
    using Project.WebAPI.DataModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public class GamesController : BaseApiController
    {
        private const string NoBluePlayer = "No blue player yet";

        public GamesController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(GameDataModel game)
        {
            var currentUserID = this.User.Identity.GetUserId();

            var newGame = new Game
            {
                Name = game.Name,
                RedId = currentUserID,
                GameState = GameState.WaitingForOpponent,
                DateCreated = DateTime.Now
            };

            this.data.Games.Add(newGame);
            this.data.SaveChanges();

            game.Id = newGame.Id;
            game.Blue = NoBluePlayer;
            game.Red = this.User.Identity.GetUserName();
            game.GameState = newGame.GameState;
            game.DateCreated = newGame.DateCreated;

            return this.Created("api/games", game);
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult Details(int id)
        {
            var games = this.data.Games.All()
                .Where(g => g.GameState == GameState.RedInTurn || g.GameState == GameState.BlueInTurn)
                .Select(g => new GameDetailsDataModel(g, this.data)).ToList();

            return this.Ok(games);
        }

        [Authorize]
        [HttpPut]
        public IHttpActionResult Join(GameDataModel game)
        {
            var currentGame = this.data.Games.All().FirstOrDefault(g => g.GameState == GameState.WaitingForOpponent);

            if (currentGame == null)
            {
                this.NotFound();
            }

            this.data.Users.All().FirstOrDefault(u => u.Id == this.User.Identity.GetUserId()).UserNumber = game.Number;

            return this.Ok(new { result = string.Format("You joined game \"{0}\"", currentGame.Name) });
        }

        [HttpGet]
        public IHttpActionResult GetPages(int page)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.Ok(this.GetPagesWithAuth(page));
            }
            else
            {
                return this.Ok(this.GetPagesWithoutAuth(page));
            }
        }

        private ICollection<GameDataModel> GetPagesWithAuth(int page)
        {
            var currentUserId = this.User.Identity.GetUserId();
            var games = this.GetAllGamesOrdered()
                .Where(g => g.BlueId == null || g.RedId == currentUserId)
                .Skip(page)
                .Take(10)
                .Select(x => new GameDataModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Blue = x.BlueId == null ? NoBluePlayer : x.Blue.UserName,
                    Red = x.Red.UserName,
                    GameState = x.GameState,
                    DateCreated = x.DateCreated
                }).ToList();

            return games;
        }

        private ICollection<GameDataModel> GetPagesWithoutAuth(int page)
        {
            var games = this.GetAllGamesOrdered()
                .Where(g => g.BlueId == null)
                .Skip(page)
                .Take(10)
                .Select(x => new GameDataModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Blue = x.BlueId == null ? NoBluePlayer : x.Blue.UserName,
                    Red = x.Red.UserName,
                    GameState = x.GameState,
                    DateCreated = x.DateCreated
                }).ToList();

            return games;
        }

        private IQueryable<Game> GetAllGamesOrdered()
        {
            var orderedGames = this.data.Games.All()
                .OrderBy(g => g.GameState)
                .ThenBy(g => g.Name)
                .ThenBy(g => g.DateCreated)
                .ThenBy(g => g.Red.UserName);

            return orderedGames;
        }
    }
}