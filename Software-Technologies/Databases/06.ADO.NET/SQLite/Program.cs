namespace SQLite
{
    using System;
    using System.Data.SQLite;

    public class WorkingWithSQLite
    {
        private static readonly BookLibrary bookLibrary = new BookLibrary();
        private static SQLiteConnection sqliteConnection = new SQLiteConnection(Settings.Default.DbConnection);

        public static void Main()
        {
            try
            {
                ConnectToDatabase();
                // AddBooks(); // The books are already added!
                FindBooksByName("C# 5.0 in a Nutshell");
                ListingAllBooks();
                DeleteAllRecords();
            }
            finally
            {
                DisconnectFromDatabase();
            }
        }

        private static void AddBooks()
        {
            Console.WriteLine("Adding books: ");
            SQLiteCommand sqliteCommand = new SQLiteCommand(@"INSERT INTO Books (Title, Author, PublishDate, ISBN)
                                                             VALUES (@title, @author, @publishDate, @isbn)",
                                                           sqliteConnection);
            foreach (var book in bookLibrary.Books)
            {
                var title = book.Title;
                var author = book.Author;
                var publishDate = book.PublishDate;
                var isbn = book.ISBN;
                sqliteCommand.Parameters.AddWithValue("@title", title);
                sqliteCommand.Parameters.AddWithValue("@author", author);
                sqliteCommand.Parameters.AddWithValue("@publishDate", publishDate);
                sqliteCommand.Parameters.AddWithValue("@isbn", isbn);
                var queryResult = sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Parameters.Clear();
                Console.WriteLine(" ({0} row(s) affected)", queryResult);
            }
        }

        private static void FindBooksByName(string substring)
        {
            Console.WriteLine("\nFinding books by name '{0}':", substring);
            SQLiteCommand sqliteCommand = new SQLiteCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                             FROM Books
                                                             WHERE CHARINDEX(@substring, Title)",
                                                           sqliteConnection);
            sqliteCommand.Parameters.AddWithValue("@substring", substring);
            using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    var author = reader["Author"].ToString();
                    var publishDate = (DateTime)reader["PublishDate"];
                    var isbn = reader["ISBN"].ToString();
                    var book = new Book()
                    {
                        Title = title,
                        Author = author,
                        PublishDate = publishDate,
                        ISBN = isbn
                    };
                    Console.WriteLine(book);
                }
            }
        }

        private static void ListingAllBooks()
        {
            Console.WriteLine("Listing all books: ");
            SQLiteCommand sqliteCommand = new SQLiteCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                              FROM Books", sqliteConnection);
            using (SQLiteDataReader reader = sqliteCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    var author = reader["Author"].ToString();
                    var publishDate = (DateTime)reader["PublishDate"];
                    var isbn = reader["ISBN"].ToString();
                    var book = new Book()
                    {
                        Title = title,
                        Author = author,
                        PublishDate = publishDate,
                        ISBN = isbn
                    };
                    Console.WriteLine(book);
                }
            }
        }

        private static void DeleteAllRecords()
        {
            Console.WriteLine("Deleting all books: ");
            SQLiteCommand mySqlCommand = new SQLiteCommand(@"DELETE FROM Books
                                                             WHERE BookId > 0", sqliteConnection);
            var queryResult = mySqlCommand.ExecuteNonQuery();
            Console.WriteLine(" ({0} row(s) affected)\n", queryResult);
        }

        private static void ConnectToDatabase()
        {
            sqliteConnection = new SQLiteConnection(Settings.Default.DbConnection);
            sqliteConnection.Open();
        }

        private static void DisconnectFromDatabase()
        {
            if (sqliteConnection != null)
            {
                sqliteConnection.Close();
            }
        }
    }
}