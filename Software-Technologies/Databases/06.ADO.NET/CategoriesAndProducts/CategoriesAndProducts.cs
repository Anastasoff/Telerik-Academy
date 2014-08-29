// 3. Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. 
// Can you do this with a single SQL query (with table join)?
namespace CategoriesAndProducts
{
    using System;
    using System.Data.SqlClient;

    internal class CategoriesAndProducts
    {
        private static void Main(string[] args)
        {
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var query = @"
                    SELECT c.CategoryName, p.ProductName
                    FROM Categories c JOIN Products p ON
                    p.CategoryID = c.CategoryID
                    ORDER BY c.CategoryName";
                var cmd = new SqlCommand(query, dbCon);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} ({1})", reader["ProductName"], reader["CategoryName"]);
                }
            }
        }
    }
}