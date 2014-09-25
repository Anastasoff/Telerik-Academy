namespace Project.WebAPI.Controllers
{
    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using Project.WebAPI.DataModels;
    using System.Linq;
    using System.Web.Http;

    public class NotificationsController : BaseApiController
    {
        public NotificationsController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult All()
        {
            return this.All(0);
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult All(int page)
        {
            var notifications = this.data.Notifications.All()
                .OrderBy(n => n.DateCreated)
                .Skip(page)
                .Take(10)
                .Select(NotificationDataModel.FromNotification);

            if (notifications == null)
            {
                this.NotFound();
            }

            return this.Ok(notifications);
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult Next()
        {
            var oldest = this.data.Notifications.All()
                .OrderBy(n => n.DateCreated)
                .FirstOrDefault(n => n.State == NotificationState.Unread);

            if (oldest == null)
            {
                return this.NotFound();
            }

            var result = new NotificationDataModel
            {
                Id = oldest.Id,
                Message = oldest.Message,
                DateCreated = oldest.DateCreated,
                Type = oldest.Type,
                State = oldest.State,
                GameId = oldest.GameId
            };

            oldest.State = NotificationState.Read;
            this.data.SaveChanges();

            return this.Ok(oldest);
        }
    }
}