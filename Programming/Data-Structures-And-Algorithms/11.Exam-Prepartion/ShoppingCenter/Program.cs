namespace ShoppingCenter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Wintellect.PowerCollections;

    public class Program
    {
        private static ShoppingCenter shoppingCenter;
        private static StringBuilder output;
        private const string AddProductStr = "AddProduct";
        private const string DeleteProducts = "DeleteProducts";
        private const string FindProductsByName = "FindProductsByName";
        private const string FindProductsByProducer = "FindProductsByProducer";
        private const string FindProductsByPriceRange = "FindProductsByPriceRange";

        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            shoppingCenter = new ShoppingCenter();
            output = new StringBuilder();

            CommandProcessor();

            Console.Write(output.ToString());
        }

        private static void CommandProcessor()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();

                if (currentLine.StartsWith(AddProductStr))
                {
                    string[] currentProduct = currentLine.Substring(AddProductStr.Length + 1).Split(';');
                    shoppingCenter.AddProduct(currentProduct[0], double.Parse(currentProduct[1]), currentProduct[2]);
                    output.AppendLine("Product added");
                }
                else if (currentLine.StartsWith(DeleteProducts))
                {
                    string[] currentParams = currentLine.Substring(DeleteProducts.Length + 1).Split(';');
                    int productsAdded = 0;
                    if (currentParams.Length == 1)
                    {
                        productsAdded = shoppingCenter.DeleteProducts(currentParams[0]);
                    }
                    else
                    {
                        productsAdded = shoppingCenter.DeleteProducts(currentParams[0], currentParams[1]);
                    }

                    if (productsAdded > 0)
                    {
                        string result = string.Format("{0} products deleted", productsAdded);
                        output.AppendLine(result);
                    }
                    else
                    {
                        output.AppendLine("No products found");
                    }
                }
                else if (currentLine.StartsWith(FindProductsByName))
                {
                    string currentName = currentLine.Substring(FindProductsByName.Length + 1);
                    var foundProducts = shoppingCenter.FindProductsByName(currentName);
                    ProcessOutput(foundProducts);
                }
                else if (currentLine.StartsWith(FindProductsByProducer))
                {
                    string currentProducer = currentLine.Substring(FindProductsByProducer.Length + 1);
                    var foundProducts = shoppingCenter.FindProductsByProducer(currentProducer);
                    ProcessOutput(foundProducts);
                }
                else if (currentLine.StartsWith(FindProductsByPriceRange))
                {
                    string[] currentRanges = currentLine.Substring(FindProductsByPriceRange.Length + 1).Split(';');
                    double fromRange = double.Parse(currentRanges[0]);
                    double toRange = double.Parse(currentRanges[1]);
                    var foundProducts = shoppingCenter.FindProductsByPriceRange(fromRange, toRange);
                    ProcessOutput(foundProducts);
                }
            }
        }

        private static void ProcessOutput(IEnumerable<Product> foundProducts)
        {
            if (!foundProducts.IsEmpty())
            {
                foreach (var product in foundProducts)
                {
                    string result = string.Format("{{{0};{1};{2:0.00}}}", product.Name, product.Producer, product.Price);
                    output.AppendLine(result);
                }
            }
            else
            {
                output.AppendLine("No products found");
            }
        }
    }

    public static class Utils
    {
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }
    }

    public class Product : IComparable<Product>
    {
        public Product(string name, double price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Producer { get; set; }

        public int CompareTo(Product obj)
        {
            int result = this.Name.CompareTo(obj.Name);
            if (result == 0)
            {
                result = this.Producer.CompareTo(obj.Producer);
            }

            if (result == 0)
            {
                result = this.Price.CompareTo(obj.Price);
            }

            return result;
        }
    }

    public class ShoppingCenter
    {
        private const int InitSize = 25025;

        private OrderedBag<Product> products;

        public ShoppingCenter()
        {
            this.products = new OrderedBag<Product>();
        }

        public void AddProduct(string name, double price, string producer)
        {
            this.products.Add(new Product(name, price, producer));
        }

        public int DeleteProducts(string name, string producer)
        {
            var result = this.products.RemoveAll(x => x.Name == name && x.Producer == producer);
            return result.Count;
        }

        public int DeleteProducts(string producer)
        {
            var result = products.RemoveAll(x => x.Producer == producer);
            return result.Count;
        }

        public IEnumerable<Product> FindProductsByName(string name)
        {
            return this.products.FindAll(x => x.Name == name);
        }

        public IEnumerable<Product> FindProductsByPriceRange(double fromRange, double toRange)
        {
            return this.products.FindAll(x => x.Price >= fromRange && x.Price <= toRange);
        }

        public IEnumerable<Product> FindProductsByProducer(string producer)
        {
            return this.products.FindAll(x => x.Producer == producer);
        }
    }
}