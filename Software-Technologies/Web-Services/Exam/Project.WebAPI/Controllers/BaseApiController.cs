namespace Project.WebAPI.Controllers
{
    using Project.Data;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        protected IProjectData data;

        public BaseApiController(IProjectData data)
        {
            this.data = data;
        }
    }
}