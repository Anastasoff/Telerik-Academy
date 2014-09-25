namespace Project.WebAPI.Controllers
{
    using BullsAndCows.Data;
    using System.Linq;
    using System.Web.Http;

    public class ScoresController : BaseApiController
    {
        public ScoresController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var scores = this.data.Scores.All()
                .OrderBy(s => s.Rank)
                .ThenBy(s => s.Username)
                .Take(10)
                .Select(s => new
                {
                    Username = s.Username,
                    Rank = s.Rank
                });

            if (scores == null)
            {
                return this.NotFound();
            }

            return this.Ok(scores);
        }
    }
}