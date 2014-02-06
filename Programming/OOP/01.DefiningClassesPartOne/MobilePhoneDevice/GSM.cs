namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        // 6. Add a static field and a property IPhone5S in the GSM class to hold the information about iPhone 5S.
        private static GSM iPhone5S;

        // 1. Define a class that holds information about a mobile phone device:
        private string model;
        private string manufacturer;
        private double price;
        private string owner;

        // Class GSM holding instances of the classes Battery and Display
        private Battery battery;
        private Display display;

        // 9. Try to use the system class List<Call>.
        private List<Call> callHistory;

        // 2. Define constructors for the defined classes that take different sets of arguments.
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0.0, null, null, null)
        {
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null, null, null)
        {
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.battery = new Battery();
            this.display = new Display();
        }

        // Property IPhone5S in the GSM class to hold the information about iPhone 5S.
        public static string IPhone5S
        {
            get
            {
                iPhone5S = new GSM("iPhone5S", "Apple");
                iPhone5S.Price = 599;
                iPhone5S.Owner = "Bob";

                iPhone5S.battery = new Battery();
                iPhone5S.battery.BatteryType = BatteryType.LiPol;
                iPhone5S.battery.Model = "Non-removable";
                iPhone5S.battery.Idle = 400;
                iPhone5S.battery.Talk = 10;

                iPhone5S.display = new Display();
                iPhone5S.display.Size = 4.5;
                iPhone5S.display.Colors = "16M";

                return iPhone5S.ToString();
            }
        }

        // 5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Length >= 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The model should be at least 2 chars!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value.Length >= 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The manufacturer should be at least 2 chars!");
                }
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The price should be positive number!");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value.Length >= 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The owner should be at least 2 chars!");
                }
            }
        }

        // 9. Add a property CallHistory in the GSM class to hold a list of the performed calls.
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        // 4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}, Price: ${2}, Owner: {3}, \n Battery: {4}, \n Display: {5}", this.model, this.manufacturer, this.price, this.owner, this.battery, this.display);
        }

        // 10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
        public void AddCall(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.callHistory.Add(new Call(dateAndTime, dialedPhone, duration));
        }

        public void DeleteCall(int callCounter)
        {
            this.CallHistory.RemoveAt(callCounter);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        // 11. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
        public string TotalPrice(double pricePerMinute)
        {
            double totalTimeTalked = 0;
            foreach (var call in this.CallHistory)
            {
                totalTimeTalked += call.Duration;
            }

            double totalPrice = (totalTimeTalked / 60) * pricePerMinute;
            return string.Format("The total price is: ${0:F2}", totalPrice);
        }
    }
}