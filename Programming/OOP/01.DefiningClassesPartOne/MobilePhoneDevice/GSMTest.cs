namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        // 7. Write a class GSMTest to test the GSM class:
        public static void Main()
        {
            DisplayGSMInformation(InputGSM());
            GSMCallHistoryTest.DisplayCallInformation(GSMCallHistoryTest.InputCall());
        }

        public static List<GSM> InputGSM()
        {
            // Create an array of few instances of the GSM class.
            List<GSM> phones = new List<GSM>();
            phones.Add(new GSM("Galaxy S4", "Samsung", 480, "Vanio", new Battery(BatteryType.LiPol, "Removable", 400, 18), new Display(5.0, "16M")));
            phones.Add(new GSM("3310", "Nokia", 15.50, "Pesho", new Battery(BatteryType.NiMH, null, 180, 2), new Display(1.5, "Black and White")));
            return phones;
        }

        public static void DisplayGSMInformation(List<GSM> phones)
        {
            // Display the information about the GSMs in the array.
            foreach (GSM item in phones)
            {
                Console.WriteLine(item);
            }

            // Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone5S);
            Console.WriteLine(new string('=', 60));
        }
    }
}