namespace ForumSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ForumSystem.Data.Common.Models;
    using ForumSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ForumSystemDbContext : IdentityDbContext<User>
    {
        public ForumSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            // The migrations are called in the Global.asax.cs file
        }

        public virtual IDbSet<Tag> Tags { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Feedback> Feedbacks { get; set; }

        public static ForumSystemDbContext Create()
        {
            return new ForumSystemDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}