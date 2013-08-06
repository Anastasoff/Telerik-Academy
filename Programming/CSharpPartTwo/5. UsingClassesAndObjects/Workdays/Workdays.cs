// 5. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//      Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static void NumberOfWorkdays(DateTime date)
    {
        DateTime[] holidays =
        {
            new DateTime(2013, 01, 1),
            new DateTime(2013, 03, 03),
            new DateTime(2013, 05, 01),
            new DateTime(2013, 05, 02),
            new DateTime(2013, 05, 03),
            new DateTime(2013, 05, 04),
            new DateTime(2013, 05, 05),
            new DateTime(2013, 05, 06),
            new DateTime(2013, 05, 24),
            new DateTime(2013, 09, 06),
            new DateTime(2013, 09, 22),
            new DateTime(2013, 11, 01),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31),
        };

        DateTime today = DateTime.Today;
        int allDays = (date - today).Days;
        int workDays = allDays;
        DateTime day = today;
        while (day <= date)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                workDays--;
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (day == holidays[i])
                    {
                        workDays--;
                    }
                }
            }

            day = day.AddDays(1);
        }

        Console.WriteLine(workDays);
    }

    static DateTime Input()
    {
        Console.Write("Enter Date in this Format(DD/MM/YYYY): ");
        string strDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(strDate, "d", null);
        return date;
    }

    static void Main()
    {        
        NumberOfWorkdays(Input());
    }
}


