namespace MusicCatalog.Services.Controllers
{
    using MusicCatalog.Data;
    using MusicCatalog.Models;
    using MusicCatalog.Services.Models;
    using System.Linq;
    using System.Web.Http;

    public class ArtistsController : ApiController
    {
        private IMusicCatalogData data;

        public ArtistsController()
            : this(new MusicCatalogData())
        {
        }

        public ArtistsController(IMusicCatalogData data)
        {
            this.data = data;
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newArtist = new Artist
            {
                Name = artist.Name,
                Country = artist.Country,
                DateOfBirth = artist.DateOfBirth
            };

            this.data.Artists.Add(newArtist);
            this.data.SaveChanges();

            newArtist.ArtistID = newArtist.ArtistID;
            return this.Ok(newArtist);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var artists = this.data
                .Artists
                .All()
                .Select(ArtistModel.FromArtist);

            return this.Ok(artists);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var artist = this.data
                .Artists
                .All()
                .Where(a => a.ArtistID == id)
                .Select(ArtistModel.FromArtist)
                .FirstOrDefault();

            if (artist == null)
            {
                return this.NotFound();
            }

            return this.Ok(artist);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var existingArtist = this.data
                .Artists
                .All()
                .FirstOrDefault(a => a.ArtistID == id);

            if (existingArtist == null)
            {
                return this.NotFound();
            }

            existingArtist.Name = artist.Name;
            existingArtist.Country = artist.Country;
            existingArtist.DateOfBirth = artist.DateOfBirth;

            this.data.SaveChanges();
            artist.ArtistID = id;
            return this.Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingArtist = this.data
                .Artists
                .All()
                .FirstOrDefault(a => a.ArtistID == id);

            if (existingArtist == null)
            {
                return this.NotFound();
            }

            this.data.Artists.Delete(existingArtist);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}