namespace MusicCatalog.Services.Controllers
{
    using MusicCatalog.Data;
    using MusicCatalog.Models;
    using MusicCatalog.Services.Models;
    using System.Linq;
    using System.Web.Http;

    public class AlbumsController : ApiController
    {
        private IMusicCatalogData data;

        public AlbumsController()
            : this(new MusicCatalogData())
        {
        }

        public AlbumsController(IMusicCatalogData data)
        {
            this.data = data;
        }

        [HttpPost]
        public IHttpActionResult Create(AlbumModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var newAlbum = new Album
            {
                Title = album.Title,
                Year = album.Year,
                Producer = album.Producer
            };

            this.data.Albums.Add(newAlbum);
            this.data.SaveChanges();

            album.AlbumID = newAlbum.AlbumID;
            return this.Ok(album);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var albums = this.data
                .Albums
                .All()
                .Select(AlbumModel.FromAlbum);

            return this.Ok(albums);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var album = this.data
                .Albums
                .All()
                .Where(a => a.AlbumID == id)
                .Select(AlbumModel.FromAlbum)
                .FirstOrDefault();

            if (album == null)
            {
                return this.NotFound();
            }

            return this.Ok(album);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AlbumModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var existingAlbum = this.data
                .Albums
                .All()
                .FirstOrDefault(a => a.AlbumID == id);

            if (existingAlbum == null)
            {
                return this.NotFound();
            }

            existingAlbum.Title = album.Title;
            existingAlbum.Year = album.Year;
            existingAlbum.Producer = album.Producer;

            this.data.SaveChanges();

            album.AlbumID = id;
            return this.Ok(album);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingAlbum = this.data
                .Albums
                .All()
                .FirstOrDefault(a => a.AlbumID == id);

            if (existingAlbum == null)
            {
                return this.NotFound();
            }

            this.data.Albums.Delete(existingAlbum);
            this.data.SaveChanges();

            return this.Ok();
        }

        [HttpPost]
        public IHttpActionResult AddArtist(int id, int artistId)
        {
            var existing = this.data
                .Albums
                .All()
                .FirstOrDefault(a => a.AlbumID == id);

            if (existing == null)
            {
                return this.NotFound();
            }

            var artist = this.data
                .Artists
                .All()
                .FirstOrDefault(s => s.ArtistID == artistId);

            if (artist == null)
            {
                return this.NotFound();
            }

            existing.Artists.Add(artist);
            this.data.SaveChanges();

            return this.Ok();
        }

        [HttpPost]
        public IHttpActionResult AddSong(int id, int songId)
        {
            var existing = this.data.Albums
                .All()
                .FirstOrDefault(a => a.AlbumID == id);

            if (existing == null)
            {
                return this.NotFound();
            }

            var song = this.data
                .Songs
                .All()
                .FirstOrDefault(s => s.SongID == songId);

            if (song == null)
            {
                return this.NotFound();
            }

            existing.Songs.Add(song);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}