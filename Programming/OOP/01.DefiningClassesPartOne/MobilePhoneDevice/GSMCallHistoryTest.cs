namespace MobilePhoneDevice
{
    using System;

    // 12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    public class GSMCallHistoryTest
    {
        public static GSM InputCall()
        {
            // Create an instance of the GSM class.
            GSM testCall = new GSM("One", "HTC", 390);

            // Add few calls.
            testCall.AddCall(new DateTime(2013, 09, 25, 16, 28, 58), "0877 777 777", 0);
            testCall.AddCall(DateTime.Now, "0888 888 888", 56);
            testCall.AddCall(DateTime.Now, "0899 999 999", 350);
            return testCall;
        }

        public static void DisplayCallInformation(GSM testCall)
        {
            // Display the information about the calls.
            Console.WriteLine("\n   Call history:");
            foreach (var call in testCall.CallHistory)
            {
                Console.WriteLine("Date and time: {0}", call.DateAndTime);
                Console.WriteLine("Dialed number: {0}", call.DialedNumber);
                Console.WriteLine("Call duration: {0} seconds", call.Duration);
                Console.WriteLine(new string('-', 30));
            }

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            double pricePerMinute = 0.37;
            Console.WriteLine("\nPrice per minute is: ${0:F2}", pricePerMinute);
            Console.WriteLine("{0}", testCall.TotalPrice(0.37));

            // Remove the longest call from the history and calculate the total price again.
            int longestCall = 0;
            int longestDuration = 0;
            for (int i = 0; i < testCall.CallHistory.Count; i++)
            {
                if (testCall.CallHistory[i].Duration > longestDuration)
                {
                    longestDuration = testCall.CallHistory[i].Duration;
                    longestCall = i;
                }
            }
            
            testCall.DeleteCall(longestCall);
            Console.WriteLine("After deleting the longest call is:");
            Console.WriteLine(testCall.TotalPrice(pricePerMinute));

            // Finally clear the call history and print it.
            testCall.ClearHistory();
            Console.WriteLine("After deleting all calls are:");
            Console.WriteLine(testCall.TotalPrice(pricePerMinute));
        }
    }
}
