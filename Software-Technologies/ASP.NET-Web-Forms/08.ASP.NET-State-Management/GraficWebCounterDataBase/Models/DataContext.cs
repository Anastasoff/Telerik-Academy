namespace GraficWebCounterDataBase.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() :
            base("CounterDb")
        {
        }

        public IDbSet<UserCount> Counter { get; set; }
    }
}