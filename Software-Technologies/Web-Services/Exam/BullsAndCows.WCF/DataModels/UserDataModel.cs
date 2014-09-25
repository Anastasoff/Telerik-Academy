namespace BullsAndCows.WCF.DataModels
{
    using BullsAndCows.Models;
    using System;
    using System.Linq.Expressions;

    public class UserDataModel
    {
        public static Expression<Func<User, UserDataModel>> FromUser
        {
            get
            {
                return u => new UserDataModel
                {
                    Id = u.Id,
                    Username = u.UserName
                };
            }
        }

        public string Id { get; set; }

        public string Username { get; set; }
    }
}