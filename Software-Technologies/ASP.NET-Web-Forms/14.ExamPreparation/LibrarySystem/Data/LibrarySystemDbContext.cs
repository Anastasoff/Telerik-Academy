using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using LibrarySystem.Data.Models;
using System.Data.Entity;
using LibrarySystem.Data.Migrations;

namespace LibrarySystem.Data
{
    public class LibrarySystemDbContext : IdentityDbContext<User>
    {
        public LibrarySystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibrarySystemDbContext, Configuration>());
        }

        public static LibrarySystemDbContext Create()
        {
            return new LibrarySystemDbContext();
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}