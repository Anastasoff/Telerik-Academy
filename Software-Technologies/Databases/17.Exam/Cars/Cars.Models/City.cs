namespace Cars.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class City
    {
        private ICollection<Dealer> dealers;

        public City()
        {
            this.dealers = new HashSet<Dealer>();
        }

        [Key]
        public int CityID { get; set; }

        [Required]
        [StringLength(10)]
        [Index("IX_Name", IsUnique = false)] // switch to 'true' to make the Name unique
        public string Name { get; set; }

        public virtual ICollection<Dealer> Dealers
        {
            get
            {
                return this.dealers;
            }

            set
            {
                this.dealers = value;
            }
        }
    }
}