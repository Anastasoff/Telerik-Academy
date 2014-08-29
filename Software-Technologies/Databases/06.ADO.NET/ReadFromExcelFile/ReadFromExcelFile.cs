
namespace ReadFromExcelFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.OleDb;

    class ReadFromExcelFile
    {
        static void Main(string[] args)
        {
            string fileName = "input.xlsx";
            OleDbConnectionStringBuilder connectionBuilder = new OleDbConnectionStringBuilder();
            connectionBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            connectionBuilder.DataSource = @"..\..\" + fileName;
            connectionBuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");
            OleDbConnection excelConnection = new OleDbConnection(connectionBuilder.ConnectionString);
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Persons$]", excelConnection);
            excelConnection.Open();
            using (excelConnection)
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    int age = (int)reader["Age"];
                    Console.WriteLine("Id: {0} | {1} is {2} years old.", id, name, age);
                }
            }
        }
    }
}
