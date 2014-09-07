namespace TelerikAcademyForumRSS
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;

    public class Program
    {
        private const string RssUrl = "http://forums.academy.telerik.com/feed/qa.rss";
        private const string RssFilePath = "../../RSS/rss.xml";
        private const string JsonFilePath = "../../RSS/rss.json";

        public static void Main(string[] args)
        {
            DownloadRssFeedFile(new WebClient());

            string json = ParseXmlRssToJson();

            PrintAllQuestionTitles(json);

            var items = ParseJsonToPoco(json);
        }

        private static void DownloadRssFeedFile(WebClient webClient)
        {
            using (webClient)
            {
                webClient.DownloadFile(RssUrl, RssFilePath);
            }
        }

        private static string ParseXmlRssToJson()
        {
            var rssXml = XDocument.Load(RssFilePath);
            string rssJson = JsonConvert.SerializeXNode(rssXml, Formatting.Indented);
            File.WriteAllText(JsonFilePath, rssJson);

            return rssJson;
        }

        private static void PrintAllQuestionTitles(string json)
        {
            var jsonObj = JObject.Parse(json);
            var titles = jsonObj["rss"]["channel"]["item"].Select(i => i["title"]);
            Console.WriteLine(string.Join(Environment.NewLine, titles));
        }

        private static RssItem[] ParseJsonToPoco(string json)
        {
            var jsonObj = JObject.Parse(json);
            var itemsJson = jsonObj["rss"]["channel"]["item"].ToString();
            var items = JsonConvert.DeserializeObject<RssItem[]>(itemsJson);

            return items;
        }
    }
}