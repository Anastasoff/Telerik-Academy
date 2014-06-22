namespace MobilePhoneDevice
{
    using System;

    public class Display
    {
        // 1. Define a class that holds information about a mobile phone device:
        private double size;
        private string colors;

        // 2. Define constructors for the defined classes that take different sets of arguments.
        public Display()
            : this(0, null) // Reuse the constructor.
        {
        }

        public Display(double size, string colors)
        {
            this.size = size;
            this.colors = colors;
        }

        // Properties
        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value >= 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size should be a positive number");
                }
            }
        }

        public string Colors
        {
            get
            {
                return this.colors;
            }

            set
            {
                if (value != null)
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size should be a positive number");
                }
            }
        }

        // 4. Override ToString()
        public override string ToString()
        {
            return string.Format("Size: {0}, Number of Colors: {1}", this.size, this.colors);
        }
    }
}