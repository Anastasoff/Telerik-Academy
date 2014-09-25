namespace Project.WebAPI.DataModels
{
    using BullsAndCows.Models;
    using System;
    using System.Linq.Expressions;

    public class NotificationDataModel
    {
        public static Expression<Func<Notification, NotificationDataModel>> FromNotification
        {
            get
            {
                return n => new NotificationDataModel
                {
                    Id = n.Id,
                    Message = n.Message,
                    DateCreated = n.DateCreated,
                    Type = n.Type,
                    State = n.State,
                    GameId = n.GameId
                };
            }
        }

        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime DateCreated { get; set; }

        public NotificationType Type { get; set; }

        public NotificationState State { get; set; }

        public int GameId { get; set; }
    }
}