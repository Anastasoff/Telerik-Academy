namespace DaysOfWeekConverter.ConsoleClient
{
    using System;

    using DaysOfWeekConverterService;

    public class ConsoleClient
    {
        public static void Main()
        {
            // first start DaysOfWeekConverter.Services
            var client = new DaysOfWeekConverterClient();

            Console.WriteLine(client.GetDayOfWeek(DateTime.Now));
        }
    }
}