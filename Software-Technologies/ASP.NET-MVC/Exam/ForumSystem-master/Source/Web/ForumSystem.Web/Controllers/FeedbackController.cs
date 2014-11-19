namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Controllers.Base;
    using ForumSystem.Web.Infrastructure;
    using ForumSystem.Web.InputModels.Feedback;
    using Microsoft.AspNet.Identity;

    public class FeedbackController : Controller
    {
        private readonly IDeletableEntityRepository<Feedback> feedbacks;
        private readonly ISanitizer sanitizer;

        public FeedbackController(IDeletableEntityRepository<Feedback> posts, ISanitizer sanitizer)
        {
            this.feedbacks = posts;
            this.sanitizer = sanitizer;
        }

        // GET: Feedback
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FeedbackInputModel input)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.Identity.GetUserId();

                var feedback = new Feedback()
                {
                    Title = input.Title,
                    Content = this.sanitizer.Sanitize(input.Content),
                    AuthorId = userId
                };

                this.feedbacks.Add(feedback);
                this.feedbacks.SaveChanges();

                return this.RedirectToAction("Index", "Feedback");
            }

            return this.View();
        }
    }
}