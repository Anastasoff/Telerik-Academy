namespace Project.Data
{
    using Project.Data.Repositories;
    using Project.Models;

    public interface IProjectData
    {
        IRepository<ApplicationUser> Users { get; }

        // TODO: Added other entities IRepository<entity> Entities

        int SaveChanges();
    }
}