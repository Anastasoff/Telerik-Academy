namespace Northwind.Models
{
    using System.Data.Linq;

    public partial class Employee
    {
        public EntitySet<Territory> TerritoriesSet
        {
            get
            {
                EntitySet<Territory> territories = new EntitySet<Territory>();
                territories.AddRange(this.Territories);
                return territories;
            }
        }
    }
}