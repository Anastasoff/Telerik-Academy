namespace Bank
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Deposit accounts are allowed to deposit and with draw money. 
        public void Deposit(decimal amount)
        {
            this.InputCheck(amount);
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.InputCheck(amount);
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("The entered amount of money is greater than the current balance! ");
            }

            this.Balance -= amount;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateInterest(int mounts)
        {
            if (this.Balance >= 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return (this.InterestRate * this.Balance) * mounts;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} name: {1}, balance: {2:C2}, interest rate: {3:P}", this.Customer.GetType().Name, this.Customer.Name, this.Balance, this.InterestRate);
        }
    }
}
