namespace BullsAndCows.Data
{
    using BullsAndCows.Data.Migrations;
    using BullsAndCows.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class BullsAndCowsDbContext : IdentityDbContext<User>
    {
        public BullsAndCowsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BullsAndCowsDbContext, Configuration>());
        }

        public static BullsAndCowsDbContext Create()
        {
            return new BullsAndCowsDbContext();
        }

        public IDbSet<Game> Games { get; set; }

        public IDbSet<Guess> Guesses { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Score> Scores { get; set; }
    }
}