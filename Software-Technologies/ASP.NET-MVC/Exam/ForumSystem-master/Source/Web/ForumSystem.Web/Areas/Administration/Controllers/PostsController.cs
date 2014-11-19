namespace ForumSystem.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Areas.Administration.ViewModels;

    public class PostsController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public PostsController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        // GET: Administration/Posts
        public ActionResult Index()
        {
            var data = this.posts.All().Project().To<PostsViewModel>();

            return this.View(data);
        }
    }
}