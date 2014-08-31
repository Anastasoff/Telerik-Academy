namespace Northwind.ConsoleClient
{
    using System;

    using Northwind.DataAccess;
    using Northwind.Models;

    public class ConsoleClient
    {
        public static void Main(string[] args)
        {
            DataAccess.Initialize(new NorthwindDbContext());

            Console.WriteLine("Connecting to server...\n");

            //// Task 1.
            // Created Northwind.Models

            //// Task 2.
            // Console.WriteLine("Insert: ({0} row(s) affected)", InsertNewCustomer());
            // Console.WriteLine("Modify: ({0} row(s) affected)", ModifyCustomerContactTitle());
            // Console.WriteLine("Delete: ({0} row(s) affected)", DeleteCustomer());

            //// Task 3.
            // Console.WriteLine("With Linq: ");
            // GetCustomersByOrderLinq();

            //// Task 4.
            // Console.WriteLine("\nWith SQL query: ");
            // GetCustomersByOrderSql();

            //// Task 5.
            // GetSalesByRegionAndPeriod();

            //// Task 6.
            // CreateCloneDatabase();

            // Task 7.
            // Not implemented!

            //// Task 8.
            // Created new partial class Employees in Northwind.Models.Partials

            //// Task 9.
            // InsertNewOrder();

            Console.WriteLine("\nOperations executed successfully.");
        }

        public static int InsertNewCustomer()
        {
            Customer newCustomer = new Customer()
            {
                CustomerID = "AAAAA",
                CompanyName = "The Company"
            };

            return DataAccess.InsertCustomer(newCustomer);
        }

        public static int ModifyCustomerContactTitle()
        {
            Customer modifiedCustomer = new Customer()
            {
                CustomerID = "AAAAA",
                ContactTitle = "The Boss"
            };

            return DataAccess.ModifyCustomerByID(modifiedCustomer);
        }

        public static int DeleteCustomer()
        {
            string customerID = "AAAAA";

            return DataAccess.DeleteCustomerByID(customerID);
        }

        public static void GetCustomersByOrderLinq()
        {
            var customers = DataAccess.GetCustomersByOrderLinq(1997, "Canada");

            foreach (var customer in customers)
            {
                Console.WriteLine(" - " + customer.ContactName);
            }
        }

        public static void GetCustomersByOrderSql()
        {
            var customers = DataAccess.GetCustomersByOrderSql(1997, "Canada");

            foreach (var customer in customers)
            {
                Console.WriteLine(" - " + customer);
            }
        }

        public static void GetSalesByRegionAndPeriod()
        {
            var sales = DataAccess.GetSalesByRegionAndPeriod("SP", new DateTime(1997, 01, 01), new DateTime(1997, 12, 31));

            foreach (var sale in sales)
            {
                Console.WriteLine(" - {0} => {1,-12:dd.MM.yyyy}", sale.ShipRegion, sale.OrderDate);
            }
        }

        public static void CreateCloneDatabase()
        {
            throw new NotImplementedException("CreateCloneDatabase() method is not implemented");
        }

        public static void InsertNewOrder()
        {
            for (int i = 0; i < 5; i++)
            {
                Order order = new Order()
                {
                    CustomerID = "BOLID",
                    EmployeeID = 9,
                    OrderDate = new DateTime(2014, 8, 30),
                    RequiredDate = new DateTime(2014, 9, 10),
                    ShippedDate = new DateTime(2014, 8, 31),
                    ShipVia = 3,
                    Freight = 10.00M,
                    ShipName = "Telerik Academy",
                    ShipAddress = "Mladost 1",
                    ShipCity = "Sofia",
                    ShipRegion = "Sofia",
                    ShipPostalCode = "1000",
                    ShipCountry = "Bulgaria"
                };

                Console.WriteLine("Insert: ({0} row(s) affected)", DataAccess.InsertOrder(order));
            }
        }
    }
}