namespace MusicCatalog.Services.Controllers
{
    using MusicCatalog.Data;
    using MusicCatalog.Models;
    using MusicCatalog.Services.Models;
    using System.Linq;
    using System.Web.Http;

    public class SongsController : ApiController
    {
        private IMusicCatalogData data;

        public SongsController()
            : this(new MusicCatalogData())
        {
        }

        public SongsController(IMusicCatalogData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var songs = this.data
                .Songs
                .All()
                .Select(SongModel.FromSong);

            return this.Ok(songs);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var song = this.data
                .Songs
                .All()
                .Where(s => s.SongID == id)
                .Select(SongModel.FromSong)
                .FirstOrDefault();

            if (song == null)
            {
                return this.NotFound();
            }

            return this.Ok(song);
        }

        [HttpPost]
        public IHttpActionResult Create(SongModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newSong = new Song
            {
                Title = song.Title,
                Year = song.Year,
                Genre = song.Genre
            };

            this.data.Songs.Add(newSong);
            this.data.SaveChanges();

            song.SongID = newSong.SongID;
            return this.Ok(song);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, SongModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var existingSong = this.data
                .Songs
                .All()
                .FirstOrDefault(s => s.SongID == id);

            if (existingSong == null)
            {
                return this.NotFound();
            }

            existingSong.Title = song.Title;
            existingSong.Year = song.Year;
            existingSong.Genre = song.Genre;

            this.data.SaveChanges();
            song.SongID = id;
            return this.Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existing = this.data
                .Songs
                .All()
                .FirstOrDefault(s => s.SongID == id);

            if (existing == null)
            {
                return this.NotFound();
            }

            this.data.Songs.Delete(existing);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}