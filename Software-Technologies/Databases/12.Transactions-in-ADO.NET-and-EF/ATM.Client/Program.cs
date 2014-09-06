namespace ATM.Client
{
    using ATM.Data;
    using ATM.Models;
    using System;
    using System.Text;

    public class Program
    {
        private static Random rnd = new Random();
        private static ATMDbContext db = new ATMDbContext();

        public static void Main()
        {
            SeedDatabase(10);
        }

        private static void SeedDatabase(int amountOfaccounts)
        {
            for (int i = 0; i < amountOfaccounts; i++)
            {
                GenerateRandomCardAccount(db);
            }

            int rowsAffected = db.SaveChanges();
            Console.WriteLine("({0} row(s) affected)", rowsAffected);
        }

        private static void GenerateRandomCardAccount(ATMDbContext db)
        {
            CardAccount acc = new CardAccount();
            StringBuilder sb = new StringBuilder();
            // generate CardNumber
            for (int i = 0; i < 10; i++)
            {
                sb.Append(rnd.Next(0, 10).ToString());
            }

            acc.CardNumber = sb.ToString();
            sb.Clear();

            // generate CardPIN
            for (int i = 0; i < 4; i++)
            {
                sb.Append(rnd.Next(0, 5).ToString());
            }

            acc.CardPIN = sb.ToString();

            // generate CardCash
            decimal cash = rnd.Next(0, 10000);
            acc.CardCash = cash;

            db.CardAccounts.Add(acc);
        }
    }
}