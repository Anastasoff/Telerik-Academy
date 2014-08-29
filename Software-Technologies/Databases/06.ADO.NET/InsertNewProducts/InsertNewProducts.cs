// 4. Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.
namespace InsertNewProducts
{
    using System;
    using System.Data.SqlClient;

    internal class InsertNewProducts
    {
        private static void Main(string[] args)
        {
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var cmdInsert = new SqlCommand(
                    "INSERT INTO Products(ProductName, UnitPrice)" +
                    "VALUES(@productName, @unitPrice)", dbCon);
                cmdInsert.Parameters.AddWithValue("@productName", "Beer");
                cmdInsert.Parameters.AddWithValue("@unitPrice", 2.00);
                int queryResult = cmdInsert.ExecuteNonQuery();
                Console.WriteLine("{0} row(s) affected", queryResult);
            }
        }
    }
}