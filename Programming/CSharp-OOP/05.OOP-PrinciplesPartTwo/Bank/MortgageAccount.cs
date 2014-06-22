namespace Bank
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Loan and mortgage accounts can only deposit money.
        public void Deposit(decimal amount)
        {
            this.InputCheck(amount);
            this.Balance += amount;
        }

        // Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        public override decimal CalculateInterest(int mounts)
        {
            if (this.Customer is Company)
            {
                if (mounts <= 12)
                {
                    return ((this.InterestRate / 2) * this.Balance) * mounts;
                }
                else
                {
                    return (((this.InterestRate / 2) * this.Balance) * mounts) + ((this.InterestRate * this.Balance) * (mounts - 12));
                }
            }
            else if (this.Customer is Individual)
            {
                if (mounts <= 6)
                {
                    return 0;
                }
                else
                {
                    return (this.InterestRate * this.Balance) * (mounts - 6);
                }
            }
            else
            {
                throw new ArgumentException("Invalid customer type!");
            }
        }

        public override string ToString()
        {
            return string.Format("{0} name: {1}, balance: {2:C2}, interest rate: {3:P}", this.Customer.GetType().Name, this.Customer.Name, this.Balance, this.InterestRate);
        }
    }
}