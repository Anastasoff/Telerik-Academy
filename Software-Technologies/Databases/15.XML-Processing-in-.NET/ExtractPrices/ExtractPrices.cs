namespace ExtractPrices
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractPrices
    {
        private static string catalogPath = "../../../Resources/catalog.xml";

        private static void Main(string[] args)
        {
            int yearBack = 35;
            int minYear = DateTime.Now.Year - yearBack;

            XDocument catalog = XDocument.Load(catalogPath);

            var query = catalog.Descendants("album")
                .Where(a => int.Parse(a.Element("year").Value) <= minYear)
                .Select(x => new
                {
                    Name = x.Element("name").Value,
                    Price = x.Element("price").Value,
                    Year = x.Element("year").Value
                });

            foreach (var album in query)
            {
                Console.WriteLine("Album name: {0}, year: {1}, price: {2}", album.Name, album.Year, album.Price);
            }
        }
    }
}