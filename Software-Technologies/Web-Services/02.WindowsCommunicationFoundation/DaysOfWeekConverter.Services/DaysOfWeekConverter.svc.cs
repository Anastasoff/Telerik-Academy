namespace DaysOfWeekConverter.Services
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class DaysOfWeekConverter : IDaysOfWeekConverter
    {
        public string GetDayOfWeek(DateTime date)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            string dayOfWeekBG = date.ToString(DateTime.Now.ToString("dddd"));

            return dayOfWeekBG;
        }
    }
}