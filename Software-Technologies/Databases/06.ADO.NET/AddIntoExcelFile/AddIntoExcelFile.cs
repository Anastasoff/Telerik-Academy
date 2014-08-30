namespace AddIntoExcelFile
{
    using System;
    using System.Data.OleDb;

    internal class AddIntoExcelFile
    {
        private static void Main(string[] args)
        {
            var stamat = new Person()
            {
                Id = 4,
                Name = "Petkan",
                Age = 55
            };

            Console.WriteLine("Affected rows: " + AddPerson(stamat));
        }

        public static int AddPerson(Person newPerson)
        {
            OleDbConnection excelConnection = new OleDbConnection(Settings.Default.ExcelConnectionString);
            OleDbCommand command = new OleDbCommand("INSERT INTO [Persons$] (Id, Name, Age) VALUES (@Id, @Name, @Age)", excelConnection);
            excelConnection.Open();

            int affectedRows = 0;
            using (excelConnection)
            {
                command.Parameters.AddWithValue("@Id", newPerson.Id);
                command.Parameters.AddWithValue("@Name", newPerson.Name);
                command.Parameters.AddWithValue("@Age", newPerson.Age);
                affectedRows = command.ExecuteNonQuery();
            }

            return affectedRows;
        }
    }
}