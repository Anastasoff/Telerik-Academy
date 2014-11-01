namespace Chat.Data.Migrations
{
    using Chat.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chat.Data.ChatDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Chat.Data.ChatDbContext";
        }

        protected override void Seed(Chat.Data.ChatDbContext context)
        {
            var UserManager = new UserManager<ChatUser>(new UserStore<ChatUser>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
                {
                    Name = "Administrator"
                });
            }

            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
                {
                    Name = "Moderator"
                });
            }

            if (!context.Users.Any(u => u.UserName == "admin@admin"))
            {
                var user = new ChatUser()
                {
                    UserName = "admin@admin",
                    FirstName = "admin@admin",
                    LastName = "admin@admin",
                    Email = "admin@admin"
                };

                var adminresult = UserManager.Create(user, "admin@admin");

                if (adminresult.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Administrator");
                }
            }

            if (!context.Users.Any(u => u.UserName == "mod@mod"))
            {
                var user = new ChatUser()
                {
                    UserName = "mod@mod",
                    FirstName = "mod@mod",
                    LastName = "mod@mod",
                    Email = "mod@mod"
                };

                var adminresult = UserManager.Create(user, "mod@mod");

                if (adminresult.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Moderator");
                }
            }

            base.Seed(context);
            //context.SaveChanges();
        }
    }
}