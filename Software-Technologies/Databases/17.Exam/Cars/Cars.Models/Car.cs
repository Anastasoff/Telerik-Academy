namespace Cars.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]
        public int CarID { get; set; }

        [Required]
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }

        [Required]
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        [Required]
        public TransmissionType TransmissionType { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey("Dealer")]
        public int DealerID { get; set; }

        public virtual Dealer Dealer { get; set; }
    }
}