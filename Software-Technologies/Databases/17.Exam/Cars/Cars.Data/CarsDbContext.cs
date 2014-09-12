namespace Cars.Data
{
    using Cars.Data.Migrations;
    using Cars.Models;
    using System.Data.Entity;

    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            : base("CarsDbConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());
        }

        public IDbSet<Car> Cars { get; set; }

        public IDbSet<Manufacturer> Manufactures { get; set; }

        public IDbSet<Dealer> Dealers { get; set; }

        public IDbSet<City> Cities { get; set; }
    }
}