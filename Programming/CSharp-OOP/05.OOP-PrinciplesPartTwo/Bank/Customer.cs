namespace Bank
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length <= 1 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid customer name!");
                }

                this.name = value;
            }
        }
    }
}