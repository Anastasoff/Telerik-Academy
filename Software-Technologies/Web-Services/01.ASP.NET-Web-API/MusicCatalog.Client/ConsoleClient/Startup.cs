namespace ConsoleClient
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class Startup
    {
        private const string WebApiUri = @"http://localhost:44453/";
        private const string HeaderValue = "application/json";

        private const string Artists = "api/Artists/";
        private const string Songs = "api/Songs/";
        private const string Albums = "api/Albums/";

        private const string Create = "Create";
        private const string GetAll = "GetAll/";
        private const string GetById = "GetById/";
        private const string Update = "Update/";
        private const string Delete = "Delete/";

        private const string AddArtist = "AddArtist/";
        private const string AddSong = "AddSong/";

        private static HttpClient client = new HttpClient { BaseAddress = new Uri(WebApiUri) };

        internal static void Main()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HeaderValue));

            CreateArtist("Drisko", "Bulgaristan", DateTime.Now);
        }

        public static void CreateArtist(string name, string country, DateTime dateOfBirth)
        {
            Console.WriteLine("Creating an artist...");

            var artist = new
            {
                Name = name,
                Country = country,
                DateOfBirth = dateOfBirth
            };

            HttpResponseMessage response = client.PutAsJsonAsync(Artists + Create, artist).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void CreateSong(string title, int year, string genre)
        {
        }

        public static void CreateAlbum(string title, int year, string producer)
        {
        }
    }
}