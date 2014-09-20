namespace MusicCatalog.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }
    }
}