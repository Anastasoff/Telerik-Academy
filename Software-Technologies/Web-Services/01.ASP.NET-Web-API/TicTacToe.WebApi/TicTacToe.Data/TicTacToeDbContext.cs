namespace TicTacToe.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using TicTacToe.Data.Contracts;
    using TicTacToe.Data.Migrations;
    using TicTacToe.Models;

    public class TicTacToeDbContext : IdentityDbContext<User>, ITicTacToeDbContext
    {
        public TicTacToeDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TicTacToeDbContext, Configuration>());
        }

        public IDbSet<Game> Games { get; set; }

        public IDbSet<Score> Scores { get; set; }

        public static TicTacToeDbContext Create()
        {
            return new TicTacToeDbContext();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}