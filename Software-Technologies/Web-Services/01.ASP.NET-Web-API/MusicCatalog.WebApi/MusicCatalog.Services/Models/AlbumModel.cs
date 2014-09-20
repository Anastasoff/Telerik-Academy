namespace MusicCatalog.Services.Models
{
    using System;
    using System.Linq.Expressions;

    using MusicCatalog.Models;

    public class AlbumModel
    {
        public static Expression<Func<Album, AlbumModel>> FromAlbum
        {
            get
            {
                return (album => new AlbumModel
                {
                    AlbumID = album.AlbumID,
                    Title = album.Title,
                    Year = album.Year,
                    Producer = album.Producer
                });
            }
        }

        public int AlbumID { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }
    }
}