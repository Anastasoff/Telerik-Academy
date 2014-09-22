namespace Project.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Project.Data.Migrations;
    using Project.Models;
    using System.Data.Entity;

    public class ProjectDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProjectDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDbContext, Configuration>());
        }

        public static ProjectDbContext Create()
        {
            return new ProjectDbContext();
        }

        // TODO: Add IDbSets
    }
}