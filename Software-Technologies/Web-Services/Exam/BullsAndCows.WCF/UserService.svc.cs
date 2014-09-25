namespace BullsAndCows.WCF
{
    using BullsAndCows.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    public class UserService : IUserService
    {
        public ICollection<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}
