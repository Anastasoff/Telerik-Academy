namespace mIRC.Client
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;
    using System.Linq;

    public class Client
    {
        private static string DatabaseHost = Connections.Default.Mongolab;
        private static string DatabaseName = "mirc";

        public static void Main()
        {
            var db = GetDatabase();
            var messages = db.GetCollection<BsonDocument>("Messages");

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello {0}!", username);

            while (true)
            {
                Console.Write("> ");
                string inputCommand = Console.ReadLine();

                if (inputCommand == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (!string.IsNullOrWhiteSpace(inputCommand))
                {
                    messages.Insert(
                        new BsonDocument
                        {
                            {
                                "User", username
                            },
                            {
                                "Message", inputCommand
                            },
                            {
                                "Sent", DateTime.Now
                            }
                        });
                }

                var outputMessages = messages
                    .FindAll()
                    .Select(msg => string.Format("[{0}] {1}: {2}", msg["Sent"].ToLocalTime(), msg["User"], msg["Message"]));

                Console.WriteLine(string.Join(Environment.NewLine, outputMessages));
            }
        }

        private static MongoDatabase GetDatabase()
        {
            var mongoClient = new MongoClient(Connections.Default.Mongolab);
            var server = mongoClient.GetServer();
            return server.GetDatabase(DatabaseName);
        }
    }
}