namespace ForumSystem.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;

    public class IndexBlogPostViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}