namespace MusicCatalog.Data.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Detach(T entity);

        int SaveChanges();
    }
}