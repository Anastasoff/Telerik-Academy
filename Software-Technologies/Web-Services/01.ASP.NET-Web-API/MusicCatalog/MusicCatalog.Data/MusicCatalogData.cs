namespace MusicCatalog.Data
{
    using MusicCatalog.Data.Repository;
    using MusicCatalog.Models;
    using System;
    using System.Collections.Generic;

    public class MusicCatalogData : IMusicCatalogData
    {
        private IMusicCatalogDbContext context;
        private IDictionary<Type, object> repositories;

        public MusicCatalogData()
            : this(new MusicCatalogDbContext())
        {
        }

        public MusicCatalogData(IMusicCatalogDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public IRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }

        public IRepository<Song> Songs
        {
            get
            {
                return this.GetRepository<Song>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), this.context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }
    }
}