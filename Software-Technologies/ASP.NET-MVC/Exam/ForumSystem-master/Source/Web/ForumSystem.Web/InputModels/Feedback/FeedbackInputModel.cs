namespace ForumSystem.Web.InputModels.Feedback
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using ForumSystem.Data.Models;

    public class FeedbackInputModel
    {
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "Content")]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Content { get; set; }

        public User Author { get; set; }
    }
}