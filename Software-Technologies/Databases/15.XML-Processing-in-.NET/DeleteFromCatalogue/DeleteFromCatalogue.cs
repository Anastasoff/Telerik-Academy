namespace DeleteFromCatalogue
{
    using System;
    using System.Globalization;
    using System.Xml;

    internal class DeleteFromCatalogue
    {
        private static string catalogPath = "../../../Resources/catalog.xml";
        private static string modifiedCatalogPath = "../../../Resources/modCatalog.xml";
        private static CultureInfo culture = CultureInfo.GetCultureInfo("en-Us");

        private static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(catalogPath);
            XmlNode rootNode = doc.DocumentElement;
            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
            {
                XmlNode node = rootNode.ChildNodes[i];
                if (decimal.Parse(node["price"].InnerText, NumberStyles.Currency, culture) > 5.0m)
                {
                    XmlNode parent = rootNode;
                    parent.RemoveChild(node);
                    Console.WriteLine("Album deleted: {0}", node["name"].InnerText);
                }
            }

            doc.Save(modifiedCatalogPath);
        }
    }
}