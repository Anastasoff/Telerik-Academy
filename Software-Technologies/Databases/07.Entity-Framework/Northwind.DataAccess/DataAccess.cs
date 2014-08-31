namespace Northwind.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Transactions;

    using Northwind.Models;

    public static class DataAccess
    {
        private static NorthwindDbContext db;

        public static void Initialize(NorthwindDbContext dbContext)
        {
            db = dbContext;
        }

        // Task 2.
        public static Customer GetCustomerByID(string customerID)
        {
            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            return customer;
        }

        public static int InsertCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            return db.SaveChanges();
        }

        public static int ModifyCustomerByID(Customer customer)
        {
            var modifiedCustomer = GetCustomerByID(customer.CustomerID);

            if (modifiedCustomer != null)
            {
                // TODO: find out proper way to do it

                //modifiedCustomer.CompanyName = customer.CompanyName;
                //modifiedCustomer.ContactName = customer.ContactName;
                modifiedCustomer.ContactTitle = customer.ContactTitle;
                //modifiedCustomer.Address = customer.Address;
                //modifiedCustomer.City = customer.City;
                //modifiedCustomer.Region = customer.Region;
                //modifiedCustomer.PostalCode = customer.PostalCode;
                //modifiedCustomer.Country = customer.Country;
                //modifiedCustomer.Phone = customer.Phone;
                //modifiedCustomer.Fax = customer.Fax;
            }

            return db.SaveChanges();
        }

        public static int DeleteCustomerByID(string customerID)
        {
            var removedCustomer = GetCustomerByID(customerID);

            if (removedCustomer != null)
            {
                db.Customers.Remove(removedCustomer);
            }

            return db.SaveChanges();
        }

        // Task 3.
        public static IEnumerable<Customer> GetCustomersByOrderLinq(int year, string coutry)
        {
            var customers = db.Orders
                .Where(order => order.OrderDate.Value.Year == year && order.ShipCountry == coutry)
                .Select(customer => customer.Customer).Distinct().ToList();

            return customers;
        }

        // Task 4.
        public static IEnumerable<string> GetCustomersByOrderSql(int year, string country)
        {
            string query =
                @"SELECT DISTINCT c.ContactName
                  FROM Orders o
                  JOIN Customers c
                    ON o.CustomerID = c.CustomerID
                  WHERE YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1}
                  ORDER BY c.ContactName";

            object[] parameters = { year, country };
            var customers = db.Database.SqlQuery<string>(query, parameters);
            return customers;
        }

        // Task 5.
        public static IEnumerable<Order> GetSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            var sales = db.Orders
                .Where(order => order.ShipRegion == region)
                .Where(order => order.OrderDate >= startDate && order.OrderDate <= endDate)
                .ToList();

            return sales;
        }

        // Task 9.
        public static int InsertOrder(Order order)
        {
            TransactionScope scope = new TransactionScope();
            using (scope)
            {
                db.Orders.Add(order);

                scope.Complete();
            }

            return db.SaveChanges();
        }
    }
}