namespace Computers.HardwareComponents
{
    using System;

    public class RAM
    {
        private int amount;
        private int value;

        public RAM(int amount)
        {
            this.Amount = amount;
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Ram should be more than 0.");
                }

                this.amount = value;
            }
        }

        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}