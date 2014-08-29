// 2. Write a program that retrieves the name and description of all categories in the Northwind DB.
namespace CategoriesNameAndDescription
{
    using System;
    using System.Data.SqlClient;

    internal class CategoriesNameAndDescription
    {
        private static void Main()
        {
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}: \t{1}", reader["CategoryName"], reader["Description"]);
                }
            }
        }
    }
}