namespace ForumSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ForumSystem.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<ForumSystemDbContext>
    {
        private Random rnd = new Random();

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ForumSystemDbContext context)
        {
            this.SeedUsers(context);
            this.SeedTags(context);
            this.SeedPosts(context);
        }

        private void SeedUsers(ForumSystemDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var userManager = new UserManager<User>(new UserStore<User>(context));
            userManager.Create(new User() { UserName = "admin@forumsystem.com", Email = "admin@forumsystem.com", }, password: "dadada");

            userManager.Create(new User() { UserName = "pesho@forumsystem.com", Email = "pesho@forumsystem.com", }, password: "dadada");

            userManager.Create(new User() { UserName = "gosho@forumsystem.com", Email = "gosho@forumsystem.com", }, password: "dadada");
        }

        private void SeedTags(ForumSystemDbContext context)
        {
            if (context.Tags.Any())
            {
                return;
            }

            context.Tags.Add(new Tag() { Name = "C#" });
            context.Tags.Add(new Tag() { Name = "HTML" });
            context.Tags.Add(new Tag() { Name = "CSS" });
            context.Tags.Add(new Tag() { Name = "JavaScript" });
            context.Tags.Add(new Tag() { Name = "OOP" });

            context.SaveChanges();
        }

        private void SeedPosts(ForumSystemDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            var users = context.Users.Take(10).ToList();
            var tags = context.Tags.Take(10).ToList();

            for (int i = 0; i < 10; i++)
            {
                context.Posts.Add(new Post() { Title = string.Format("Sample post {0}", i), Author = users[this.rnd.Next(0, 3)], Content = "This is the content. This is the content. This is the content. This is the content. This is the content.", Tags = tags });
            }

            context.SaveChanges();
        }
    }
}