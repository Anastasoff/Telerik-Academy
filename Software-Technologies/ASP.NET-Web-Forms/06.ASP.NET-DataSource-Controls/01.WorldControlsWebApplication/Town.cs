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
    
    public partial class Town
    {
        public int TownId { get; set; }
        public string Name { get; set; }
        public Nullable<long> Population { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
