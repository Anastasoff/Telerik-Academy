namespace Project.WebAPI.Controllers
{
    using BullsAndCows.Data;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        protected IBullsAndCowsData data;

        public BaseApiController(IBullsAndCowsData data)
        {
            this.data = data;
        }
    }
}