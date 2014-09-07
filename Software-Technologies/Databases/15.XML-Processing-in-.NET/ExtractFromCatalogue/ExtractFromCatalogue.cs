namespace ExtractFromCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    internal class ExtractFromCatalogue
    {
        private static string catalogPath = "../../../Resources/catalog.xml";

        private static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(catalogPath);
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlAttribute atr in rootNode.Attributes)
            {
                Console.WriteLine("Attribute: {0}={1}", atr.Name, atr.Value);
            }

            Dictionary<string, int> producers = new Dictionary<string, int>();
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if (!producers.ContainsKey(node["producer"].InnerText))
                {
                    producers[node["producer"].InnerText] = 1;
                }
                else
                {
                    producers[node["producer"].InnerText]++;
                }
            }

            foreach (var pair in producers)
            {
                if (pair.Value != 0)
                {
                    Console.WriteLine("Producer: {0}, albums: {1} ", pair.Key, pair.Value);
                }
            }
        }
    }
}