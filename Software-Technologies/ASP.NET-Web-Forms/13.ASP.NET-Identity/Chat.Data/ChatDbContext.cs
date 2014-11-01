using Chat.Data.Migrations;
using Chat.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Chat.Data
{
    public class ChatDbContext : IdentityDbContext<ChatUser>
    {
        public ChatDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ChatDbContext>(new MigrateDatabaseToLatestVersion<ChatDbContext, Configuration>());
        }

        public static ChatDbContext Create()
        {
            return new ChatDbContext();
        }

        public IDbSet<ChatMessage> ChatMessages { get; set; }
                    
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