namespace ForumSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Feedback;

    [Authorize]
    public class PageableFeedbackListController : Controller
    {
        private const int ItemsPerPage = 4;
        private readonly IDeletableEntityRepository<Feedback> feedbacks;

        public PageableFeedbackListController(IDeletableEntityRepository<Feedback> feedbacks)
        {
            this.feedbacks = feedbacks;
        }

        public ActionResult Display(int page = 0)
        {
            if (page < 0)
            {
                page = 0;
            }

            var result = this.feedbacks
                .All()
                .OrderByDescending(x => x.CreatedOn)
                .Skip(page * ItemsPerPage)
                .Take(ItemsPerPage)
                .Project()
                .To<FeedbackDisplayViewModel>();

            return this.View("Display", result);
        }
    }
}