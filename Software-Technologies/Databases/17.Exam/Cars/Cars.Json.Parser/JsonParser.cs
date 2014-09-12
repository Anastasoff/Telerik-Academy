namespace Cars.Json.Parser
{
    using Cars.Data;
    using Cars.Models;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.IO;
    using System.Linq;

    public class JsonParser
    {
        private const string JsonFilesPath = "../../../Data.Json.Files/data.{0}.json";
        private const string JsonFilesDir = "../../../Data.Json.Files";

        public static void Parse()
        {
            try
            {
                CarsDbContext db = new CarsDbContext();
                LoadJson(db);

                Console.WriteLine("Successfully parsed! No Exceptions was caught.");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("There is such name of city or manufacturer. ", ex.Message);
            }
        }

        private static void LoadJson(CarsDbContext db)
        {
            int numberOfFiles = Directory.GetFiles(JsonFilesDir).Length;
            for (int i = 0; i < numberOfFiles; i++)
            {
                string currentPath = string.Format(JsonFilesPath, i);

                var currentJson = File.ReadAllText(currentPath);

                var cars = ParseJson(currentJson);

                foreach (var item in cars)
                {
                    db.Cars.Add(item);
                }

                Console.WriteLine("rows affected: {0}", db.SaveChanges());
            }
        }

        private static IEnumerable<Car> ParseJson(string currentJson)
        {
            var carsJson = JArray.Parse(currentJson);

            var cars = carsJson.Select(car => new Car()
            {
                Year = (int)car["Year"],
                TransmissionType = ToEnum((string)car["TransmissionType"]),
                Manufacturer = new Manufacturer()
                {
                    Name = (string)car["ManufacturerName"]
                },
                Model = (string)car["Model"],
                Price = (decimal)car["Price"],
                Dealer = new Dealer()
                {
                    Name = (string)car["Dealer"]["Name"],
                    Cities = new List<City>()
                            {
                                new City() {
                                    Name = (string)car["Dealer"]["City"]
                                }
                            }
                },
            });

            return cars;
        }

        private static TransmissionType ToEnum(string input)
        {
            if (input == "0")
            {
                return TransmissionType.Manual;
            }

            return TransmissionType.Automatic;
        }
    }
}