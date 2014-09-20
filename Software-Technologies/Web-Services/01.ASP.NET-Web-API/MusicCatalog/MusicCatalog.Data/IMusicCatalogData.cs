namespace MusicCatalog.Data
{
    using MusicCatalog.Data.Repository;
    using MusicCatalog.Models;

    public interface IMusicCatalogData
    {
        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Song> Songs { get; }

        int SaveChanges();

        void Dispose();
    }
}