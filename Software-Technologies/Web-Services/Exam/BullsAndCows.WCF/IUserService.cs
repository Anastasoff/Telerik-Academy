namespace BullsAndCows.WCF
{
    using BullsAndCows.Models;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        ICollection<User> Get();
    }
}