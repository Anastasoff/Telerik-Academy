//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01.WorldControlsWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }
    
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public Nullable<long> Population { get; set; }
        public int ContinentId { get; set; }
        public byte[] Flag { get; set; }
    
        public virtual Continent Continent { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}
