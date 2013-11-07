namespace Bank
{
    using System;

    // All accounts have customer, balance and interest rate (monthly based).
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate; // monthly based

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            protected set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate should be positive number!");
                }

                this.interestRate = value;
            }            
        }

        // Methods
        public abstract decimal CalculateInterest(int mounts);

        protected void InputCheck(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The entered amount of money should be more than zero!");
            }
        }
    }
}
