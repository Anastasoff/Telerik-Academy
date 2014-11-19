namespace ForumSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public HomeController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            var model = this.posts
                .All()
                .OrderByDescending(m => m.CreatedOn)
                .Project()
                .To<IndexBlogPostViewModel>();

            return this.View(model);
        }
    }
}