namespace ForumSystem.Web.ViewModels.Feedback
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;

    public class FeedbackDisplayViewModel : IMapFrom<Feedback>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }
}