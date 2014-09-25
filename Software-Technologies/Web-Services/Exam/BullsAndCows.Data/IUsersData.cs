namespace BullsAndCows.Data
{
    using BullsAndCows.Data.Repositories;
    using BullsAndCows.Models;

    public interface IUsersData
    {
        IRepository<User> Users { get; }

        int SaveChanges();
    }
}