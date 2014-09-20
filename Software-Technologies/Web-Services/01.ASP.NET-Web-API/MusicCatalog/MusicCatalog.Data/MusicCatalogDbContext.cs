namespace MusicCatalog.Data
{
    using MusicCatalog.Data.Migrations;
    using MusicCatalog.Models;
    using System.Data.Entity;

    public class MusicCatalogDbContext : DbContext, IMusicCatalogDbContext
    {
        public MusicCatalogDbContext()
            : base("name=MusicCatalogConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicCatalogDbContext, Configuration>());
        }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}