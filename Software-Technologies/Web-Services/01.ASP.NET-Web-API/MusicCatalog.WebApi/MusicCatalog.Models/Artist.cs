namespace MusicCatalog.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(2)]
        [MaxLength(30)]
        public string Country { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateOfBirth { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }
    }
}