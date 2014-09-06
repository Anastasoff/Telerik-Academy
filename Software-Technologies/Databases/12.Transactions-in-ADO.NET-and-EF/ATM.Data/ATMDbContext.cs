namespace ATM.Data
{
    using ATM.Data.Migrations;
    using ATM.Models;
    using System.Data.Entity;

    public class ATMDbContext : DbContext
    {
        public ATMDbContext()
            : base("ATMConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMDbContext, Configuration>());
        }

        public virtual IDbSet<CardAccount> CardAccounts { get; set; }
    }
}