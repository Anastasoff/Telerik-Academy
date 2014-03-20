namespace StoreForCarParts
{
    using System;

    public class TestShop
    {
        public static void Main(string[] args)
        {
            Manufacturer bmw = new Manufacturer("BMW", "Germany", "Bavaria", "665544", "sale@bmw.de");
            Manufacturer lada = new Manufacturer("Lada", "Russia", "Moscow", "224477", "sale@lada.ru");

            Car bmw316i = new Car("BMW", "316i", 1994);
            Car ladaSamara = new Car("Lada", "Samara", 1987);
            Car mazdaMX5 = new Car("Mazda", "MX5", 1999);
            Car mercedesS500 = new Car("Mercedes", "S500", 2008);
            Car trabant = new Car("Trabant", "601", 1966);
            Car opelAstra = new Car("Opel", "Astra", 1997);

            Part cheapPart = new Part("Tires 165/50/R13", 302.36m, 345.58m, lada, "T332", PartCategory.Tires);
            cheapPart.AddSupportedCar(ladaSamara);
            cheapPart.AddSupportedCar(trabant);

            Part expensivePart = new Part("Universal Car Engine", 6733.17m, 6800.0m, bmw, "EU33", PartCategory.Engine);
            expensivePart.AddSupportedCar(bmw316i);
            expensivePart.AddSupportedCar(mazdaMX5);
            expensivePart.AddSupportedCar(mercedesS500);
            expensivePart.AddSupportedCar(opelAstra);

            Shop newShop = new Shop("Tuning Pro Shop");
            newShop.AddPart(cheapPart);
            newShop.AddPart(expensivePart);

            Console.Write(newShop);
        }
    }
}
