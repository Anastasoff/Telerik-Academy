namespace MobilePhoneDevice
{
    using System;

    public class Battery
    {
        // 1. Define a class that holds information about a mobile phone device:
        private BatteryType batteryType;
        private string model;
        private int idle;
        private int talk;

        // 2. Define constructors for the defined classes that take different sets of arguments.
        public Battery()
        {
        }

        public Battery(BatteryType batteryType)
            : this(batteryType, null, 0, 0)
        {
        }

        public Battery(BatteryType batteryType, string model, int hoursIdle, int hoursTalk)
        {
            this.batteryType = batteryType;
            this.model = model;
            this.idle = hoursIdle;
            this.talk = hoursTalk;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Length >= 0 || value == null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The model should be at least 2 chars!");
                }
            }
        }

        public int Idle
        {
            get
            {
                return this.idle;
            }

            set
            {
                if (value >= 0)
                {
                    this.idle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The idle hours should be a positive number");
                }
            }
        }

        public int Talk
        {
            get
            {
                return this.talk;
            }

            set
            {
                if (value >= 0)
                {
                    this.talk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The talk hours should be a positive number");
                }
            }
        }

        // Properties
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

        // 4. Override ToString()
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Idle: {2}h, Talk: {3}h", this.batteryType, this.model ?? "[No Info]", this.idle, this.talk);
        }
    }
}
