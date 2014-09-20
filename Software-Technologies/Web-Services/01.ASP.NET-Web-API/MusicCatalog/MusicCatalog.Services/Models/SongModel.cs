namespace MusicCatalog.Services.Models
{
    using System;
    using System.Linq.Expressions;
    
    using MusicCatalog.Models;

    public class SongModel
    {
        public static Expression<Func<Song, SongModel>> FromSong
        {
            get
            {
                return (song => new SongModel
                {
                    SongID = song.SongID,
                    Title = song.Title,
                    Year = song.Year,
                    Genre = song.Genre
                });
            }
        }

        public int SongID { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }
    }
}