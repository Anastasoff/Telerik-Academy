using System.ComponentModel.DataAnnotations;

namespace MusicCatalog.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public Gender Gender { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }
    }
}