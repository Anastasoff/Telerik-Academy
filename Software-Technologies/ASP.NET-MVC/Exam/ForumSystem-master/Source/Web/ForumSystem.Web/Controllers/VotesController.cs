namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;

    public class VotesController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public VotesController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult PostVote()
        {
            return null;
        }

        public ActionResult VoteUp(int id)
        {
            return null;
        }

        public ActionResult VoteDown(int id)
        {
            return null;
        }
    }
}