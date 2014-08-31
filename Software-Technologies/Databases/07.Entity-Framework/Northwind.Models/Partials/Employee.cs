namespace Northwind.Models.Partials
{
    using System.Data.Linq;

    public partial class Employee
    {
        public EntitySet<Territory> Territories
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