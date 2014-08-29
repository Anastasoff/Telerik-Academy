// 1. Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
namespace NumbersOfCategories
{
    using System;
    using System.Data.SqlClient;

    internal class NumbersOfCategories
    {
        private static void Main()
        {
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int numberOfRows = (int)command.ExecuteScalar();
                Console.WriteLine("Number of categories: {0}", numberOfRows);
            }
        }
    }
}