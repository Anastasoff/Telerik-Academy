namespace FindProducts
{
    using System;
    using System.Data.SqlClient;

    internal class FindProducts
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter your product search: ");
            string pattern = Console.ReadLine();
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var command = new SqlCommand(
                    "SELECT ProductName FROM Products " + 
                    "WHERE ProductName LIKE @Pattern", dbCon);

                pattern = pattern
                    .Replace("%", "[%]")
                    .Replace("'", "[']")
                    .Replace("\"", "[\"]")
                    .Replace("_", "[_]")
                    .ToLower();

                command.Parameters.AddWithValue("@Pattern", "%" + pattern + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}", reader["ProductName"]);
                }
            }
        }
    }
}