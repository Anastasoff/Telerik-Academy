namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        // 8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        public Call(DateTime dateAndTime)
            : this(dateAndTime, null, 0)
        {
        }

        public Call(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public DateTime DateAndTime
        {
            get
            { 
                return this.dateAndTime; 
            }

            set 
            { 
                this.dateAndTime = value; 
            }
        }

        public string DialedNumber
        {
            get 
            { 
                return this.dialedPhone; 
            }

            set
            {
                if (value.Length >= 6)
                {
                    this.dialedPhone = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The phone number should be at least 6 digits");
                }
            }
        }

        public int Duration
        {
            get
            { 
                return this.duration; 
            }

            set
            {
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The call duration should be positive number");
                }
            }
        }
    }
}