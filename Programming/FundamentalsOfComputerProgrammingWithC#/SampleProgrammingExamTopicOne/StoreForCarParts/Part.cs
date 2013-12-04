namespace StoreForCarParts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Part
    {
        private string name;
        private string code;
        private PartCategory category;
        private HashSet<Car> supportedCars;
        private decimal buyPrice;
        private decimal sellPrice;
        private Manufacturer manufacturer;

        public Part(string name, decimal buyPrice, decimal sellPrice, Manufacturer manufacturer, string code, PartCategory category)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.manufacturer = manufacturer;
            this.code = code;
            this.category = category;
            this.supportedCars = new HashSet<Car>();
        }

        public void AddSupportedCar(Car car)
        {
            this.supportedCars.Add(car);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Part: " + this.name);
            result.AppendLine(" -code: " + this.code);
            result.AppendLine(" -category: " + this.category);
            result.AppendLine(" -buyPrice: " + this.buyPrice);
            result.AppendLine(" -sellPrice: " + this.sellPrice);
            result.AppendLine(" -manufacturer: " + this.manufacturer);
            result.AppendLine("----Supported cars----");
            foreach (Car car in this.supportedCars)
            {
                result.Append(car);
                result.AppendLine();
            }

            result.AppendLine("----------------------");

            return result.ToString();
        }
    }
}
