namespace Project.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Project.Models;

    public class ProjectDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProjectDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ProjectDbContext Create()
        {
            return new ProjectDbContext();
        }
    }
}