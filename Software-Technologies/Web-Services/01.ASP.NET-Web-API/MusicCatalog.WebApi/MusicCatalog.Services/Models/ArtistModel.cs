namespace MusicCatalog.Services.Models
{
    using System;
    using System.Linq.Expressions;
    
    using MusicCatalog.Models;

    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromArtist
        {
            get
            {
                return (artist => new ArtistModel
                {
                    ArtistID = artist.ArtistID,
                    Name = artist.Name,
                    Country = artist.Country,
                    DateOfBirth = artist.DateOfBirth
                });
            }
        }

        public int ArtistID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}