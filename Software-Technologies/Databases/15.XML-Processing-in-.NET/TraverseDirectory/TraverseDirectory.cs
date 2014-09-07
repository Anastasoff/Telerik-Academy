namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class TraverseDirectory
    {
        private static string directoriesPath = "../../../Resources/directories.xml";

        private static void Main()
        {
            try
            {
                string startDirectory = "../../../";
                XElement booksXml = new XElement("directories", CreateXMLForDirectory(startDirectory));
                booksXml.Save(directoriesPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static XElement CreateXMLForDirectory(string sourceDirectory)
        {
            FileInfo fileInfoSource = new FileInfo(sourceDirectory);
            XElement roothDirectory = new XElement("directory", new XAttribute("name", fileInfoSource.Name));
            var files = Directory.EnumerateFiles(sourceDirectory);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                roothDirectory.Add(
                    new XElement("file"),
                    new XElement("name", fileInfo.Name),
                    new XElement("type", fileInfo.Extension)
                    );
            }

            var directories = Directory.EnumerateDirectories(sourceDirectory);
            foreach (var directory in directories)
            {
                roothDirectory.Add(CreateXMLForDirectory(directory));
            }

            return roothDirectory;
        }
    }
}