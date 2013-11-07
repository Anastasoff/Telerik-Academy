namespace Bank
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Loan and mortgage accounts can only deposit money.
        public void Deposit(decimal amount)
        {
            this.InputCheck(amount);
            this.Balance += amount;
        }

        // Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        public override decimal CalculateInterest(int mounts)
        {
            if (this.Customer is Company)
            {
                if (mounts <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.InterestRate * this.Balance) * (mounts - 2);
                }                
            }
            else if (this.Customer is Individual)
            {
                if (mounts <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.InterestRate * this.Balance) * (mounts - 3);
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
