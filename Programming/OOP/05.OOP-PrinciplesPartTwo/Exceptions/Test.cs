// 3. Write a sample application that demonstrates the InvalidRangeException<int> 
// and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
// and dates in the range [1.1.1980 … 31.12.2013].

namespace Exceptions
{
    using System;

    public class Test
    {
        public static void PrintNumber()
        {
            int startNumber = 0;
            int endNumber = 100;

            Console.WriteLine("Enter an integer in the range [{0} ... {1}]", startNumber, endNumber);
            int number = int.Parse(Console.ReadLine());
            if (number < startNumber || number > endNumber)
            {
                throw new InvalidRangeException<int>("Invalid integer range!", startNumber, endNumber);
            }

            Console.WriteLine("The number {0} is correct! \n", number);
        }

        public static void PrintDate()
        {
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2014, 12, 31);

            Console.WriteLine("Enter a date in the range [{0} ... {1}]", startDate.ToShortDateString(), endDate.ToShortDateString());
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Invalid date range!", startDate, endDate);
            }

            Console.WriteLine("The date {0} is correct! \n", date);
        }

        public static void Main()
        {
            try
            {
                PrintNumber();
                PrintDate();
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Caught Exception: \n{0}\n", ex.Message);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Caught Exception: \n{0}\n", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught Exception: \n{0}\n", ex.Message);
            }
        }
    }
}
