namespace OnlineMarket2
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Wintellect.PowerCollections;

    public class Solution
    {
        private const string EndCmd = "end";
        private const string AddCmd = "add";
        private const string FilterByTypeCmd = "filter by type";
        private const string FilterByPriceCmd = "filter by price";

        private static OrderedSet<Product> products;
        private static StringBuilder output;

        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            products = new OrderedSet<Product>();
            output = new StringBuilder();

            CommandProcessor();

            Console.Write(output);
        }

        private static void CommandProcessor()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == EndCmd)
                {
                    return;
                }

                int startIndex = 0;
                if (commandLine.StartsWith(AddCmd))
                {
                    string[] productStr = commandLine.Split(' ');
                    string name = productStr[1];
                    double price = double.Parse(productStr[2]);
                    string type = productStr[3];
                    var product = new Product(name, price, type);
                    if (!products.Contains(product))
                    {
                        products.Add(product);

                        output.AppendLine(string.Format("Ok: Product {0} added successfully", name));
                    }
                    else
                    {
                        output.AppendLine(string.Format("Error: Product {0} already exists", name));
                    }
                }
                else if (commandLine.StartsWith(FilterByTypeCmd))
                {
                    startIndex = FilterByTypeCmd.Length + 1;
                    string type = commandLine.Substring(startIndex);
                    var found = products.FindAll(x => x.Type == type);

                    if (found.Any())
                    {
                        output.Append("Ok: ");
                        int i = 0;
                        foreach (var pr in found)
                        {
                            if (i >= 10)
                            {
                                break;
                            }

                            output.AppendFormat("{0}({1}), ", pr.Name, pr.Price);

                            i++;
                        }

                        output.Length--;
                        output.Length--;
                        output.AppendLine();
                    }
                    else
                    {
                        output.AppendLine(string.Format("Error: Type {0} does not exists", type));
                    }
                }
                else if (commandLine.StartsWith(FilterByPriceCmd))
                {
                    startIndex = FilterByPriceCmd.Length + 1;

                    string[] parameters = commandLine.Substring(startIndex).Split(' ');
                    // from PRICE to PRICE
                    if (parameters.Length == 4)
                    {
                        double fromRange = double.Parse(parameters[1]);
                        double toRange = double.Parse(parameters[3]);
                        var found = products.FindAll(x => x.Price >= fromRange && x.Price <= toRange);

                        ProcessFilterOutput(found);
                    }
                    else
                    {
                        if (parameters[0] == "from")
                        {
                            double fromRange = double.Parse(parameters[1]);
                            var found = products.FindAll(x => x.Price >= fromRange);

                            ProcessFilterOutput(found);
                        }
                        else
                        {
                            double toRange = double.Parse(parameters[1]);
                            var found = products.FindAll(x => x.Price <= toRange);

                            ProcessFilterOutput(found);
                        }
                    }

                    output.AppendLine();
                }
            }
        }

        private static void ProcessFilterOutput(IEnumerable<Product> found)
        {
            output.Append("Ok: ");
            if (found.Any())
            {
                int i = 0;
                foreach (var pr in found)
                {
                    if (i >= 10)
                    {
                        break;
                    }
                    output.AppendFormat("{0}({1}), ", pr.Name, pr.Price);
                    i++;
                }

                output.Length--;
                output.Length--;
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
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public int CompareTo(Product obj)
        {
            int result = this.Price.CompareTo(obj.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(obj.Name);
            }
            if (result == 0)
            {
                result = this.Type.CompareTo(obj.Type);
            }
            return result;
        }
    }
}