namespace MusicCatalog.Data
{
    using MusicCatalog.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IMusicCatalogDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Song> Songs { get; set; }

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}