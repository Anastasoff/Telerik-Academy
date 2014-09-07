namespace ExtractAllSongs
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractAllSongs
    {
        private static string catalogPath = "../../../Resources/catalog.xml";

        private static void Main(string[] args)
        {
            XDocument doc = XDocument.Load(catalogPath);
            var songs = doc.Descendants("song").Select(s => s.Element("title").Value);

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}