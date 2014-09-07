namespace TxtToXml
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class TxtToXml
    {
        private static string personsTxtPath = "../../../Resources/persons.txt";
        private static string personsXmlPath = "../../../Resources/persons.xml";

        private static void Main(string[] args)
        {
            var personsTxt = File.ReadLines(personsTxtPath);
            var personsXml = new XElement("persons");

            foreach (var item in personsTxt)
            {
                var person = item.Split(';');
                var name = person[0].Trim();
                var address = person[1].Trim();
                var phoneNumber = person[2].Trim();

                personsXml.Add(new XElement("person",
                    new XElement("name", name),
                    new XElement("address", address),
                    new XElement("phone", phoneNumber)
                ));
            }

            personsXml.Save(personsXmlPath);
        }
    }
}