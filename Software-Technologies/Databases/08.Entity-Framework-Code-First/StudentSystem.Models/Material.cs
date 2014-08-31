namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        [Key, Required]
        public int MaterialID { get; set; }

        [Required]
        public string DownloadUrl { get; set; }

        [Required]
        public virtual MaterialType Type { get; set; }

        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
    }
}