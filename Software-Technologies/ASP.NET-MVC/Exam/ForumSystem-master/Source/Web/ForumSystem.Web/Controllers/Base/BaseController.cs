namespace ForumSystem.Web.Controllers.Base
{
    using System.Threading;
    using System.Web.Mvc;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using Microsoft.AspNet.Identity;    

    public abstract class BaseController : Controller
    {
        private readonly IDeletableEntityRepository<User> users;

        public BaseController(IDeletableEntityRepository<User> users)
        {
            this.users = users;
        }

        protected User CurrentUser
        {
            get
            {
                return this.users.GetById(this.GetUserId());
            }
        }

        protected string GetUserId()
        {
            return Thread.CurrentPrincipal.Identity.GetUserId();
        }
    }
}