namespace CreateCatalogue
{
    using System.Xml.Linq;

    internal class CreateCatalogue
    {
        private static string catalogPath = "../../../Resources/catalog.xml";

        private static void Main(string[] args)
        {
            XElement catalog = new XElement("catalog",
                new XElement("album",
                    new XElement("name", "Thriller"),
                    new XElement("artist", "Michael Jackson"),
                    new XElement("year", "1982"),
                    new XElement("producer", "Quincy Jones"),
                    new XElement("price", "5.99"),
                    new XElement("songs",
                        new XElement("song",
                            new XElement("title", "Thriller"),
                            new XElement("duration", "5.57")),
                        new XElement("song",
                            new XElement("title", "Billie Jean"),
                            new XElement("duration", "4.54")),
                        new XElement("song",
                            new XElement("title", "Baby Be Mine"),
                            new XElement("duration", "4.20")))),
                new XElement("album",
                    new XElement("name", "The Dark Side of the Moon"),
                    new XElement("artist", "Pink Floyd"),
                    new XElement("year", "1973"),
                    new XElement("producer", "Pink Floyd"),
                    new XElement("price", "4.99"),
                    new XElement("songs",
                        new XElement("song",
                            new XElement("title", "Breathe"),
                            new XElement("duration", "2.46")))),
                 new XElement("album",
                    new XElement("name", "Back in Black"),
                    new XElement("artist", "AC/DC"),
                    new XElement("year", "1980"),
                    new XElement("producer", "Robert John \"Mutt\" Lange"),
                    new XElement("price", "4.49"),
                    new XElement("songs",
                        new XElement("song",
                            new XElement("title", "Hells Bells"),
                            new XElement("duration", "5.13")),
                        new XElement("song",
                            new XElement("title", "Shoot the Thrill"),
                            new XElement("duration", "5.18"))))
                );

            catalog.Save(catalogPath);
        }
    }
}