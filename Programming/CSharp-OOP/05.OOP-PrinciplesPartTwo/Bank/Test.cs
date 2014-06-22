/*
  2. A bank holds different types of accounts for its customers:
 deposit accounts, loan accounts and mortgage accounts.
 Customers could be individuals or companies.

 Your task is to write a program to model the bank system by classes and interfaces.
 You should identify the classes, interfaces, base classes and abstract actions
 and implement the calculation of the interest functionality through overridden methods.
*/

namespace Bank
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Test
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Customer peshoAcc = new Individual("Pesho Peshev");
            Individual goshoAcc = new Individual("Gosho Goshev");
            Customer peshoCom = new Company("Pesho's Company Ltd.");
            Company goshoCom = new Company("Gosho's Company Ltd.");

            DepositAccount firstDepositAcc = new DepositAccount(peshoAcc, 23000.0m, 0.035m);
            LoanAccount firstLoanAcc = new LoanAccount(goshoAcc, 12000.0m, 0.053m);
            MortgageAccount firstMortgageAcc = new MortgageAccount(peshoAcc, 120000.0m, 0.024m);
            DepositAccount secondDepositAcc = new DepositAccount(peshoCom, 35000.0m, 0.041m);
            LoanAccount secondLoanAcc = new LoanAccount(goshoCom, 231000.0m, 0.049m);
            MortgageAccount secondMortgageAcc = new MortgageAccount(peshoCom, 352550.0m, 0.015m);

            Console.WriteLine(firstDepositAcc);
            Console.WriteLine(firstLoanAcc);
            Console.WriteLine(firstMortgageAcc);
            Console.WriteLine(secondDepositAcc);
            Console.WriteLine(secondLoanAcc);
            Console.WriteLine(secondMortgageAcc);
        }
    }
}