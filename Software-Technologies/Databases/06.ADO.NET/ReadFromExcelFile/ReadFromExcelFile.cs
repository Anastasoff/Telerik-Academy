namespace ReadFromExcelFile
{
    using System;
    using System.Data.OleDb;

    internal class ReadFromExcelFile
    {
        private static void Main(string[] args)
        {
            OleDbConnection excelConnection = new OleDbConnection(Settings.Default.ExcelConnectionString);
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Persons$]", excelConnection);
            excelConnection.Open();

            using (excelConnection)
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = (double)reader["Id"];
                    var name = (string)reader["Name"];
                    var age = (double)reader["Age"];
                    Console.WriteLine("Id: {0} | {1} is {2} years old.", id, name, age);
                }
            }
        }
    }
}