// 5. Write a program that retrieves the images for all categories in the Northwind database 
//  and stores them as JPG files in the file system.
namespace RetrieveAndStoreImages
{
    using System.Data.SqlClient;
    using System.IO;

    internal class RetrieveAndStoreImages
    {
        private static void Main(string[] args)
        {
            var dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();

            byte[] image = null;
            string categoryName = null;

            using (dbCon)
            {
                var command = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbCon);
                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        image = (byte[])reader["Picture"];
                        categoryName = (string)reader["CategoryName"].ToString().Replace('/', '_');
                        string dir = "../../";
                        string file = categoryName + ".JPG";
                        WriteFile(dir, image, file);
                    }
                }
            }
        }

        private static void WriteFile(string dir, byte[] image, string file)
        {
            FileStream stream = File.OpenWrite(dir + file);
            using (stream)
            {
                stream.Write(image, 78, image.Length - 78);
            }
        }
    }
}