using System;

// 14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
// bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
class BankAccount
{
    static void Main()
    {
        Console.Title = "Bank Account";

        Console.WriteLine("Personal Information: \n");
        string firstName = "Pesho";
        string middleName = "Peshev";
        string lastName = "Peshev";
        string holderName = string.Format("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine(holderName);

        Console.WriteLine(new string('=', 30));

        Console.WriteLine("Amount Information: \n");
        decimal balance = 12568.05M;
        string bankName = "Burkan Bank AG";
        string iban = "BG12ABCD00000123456789";
        string bicCode = "BUINBGSF";
        Console.WriteLine("Balance: ${0} \nBank name: {1} \nIBAN: {2} \nBIC code: {3}", balance, bankName, iban, bicCode);

        Console.WriteLine(new string('=', 30));

        Console.WriteLine("Credit Cards: \n");
        ulong firstCreditCard = 4207670054361434;
        ulong secondCreditCard = 4328810002719770;
        ulong thirdCreditCard = 5466160175050358;
        Console.WriteLine("First credit card number: '{0}' \nSecond credit card number: '{1}' \nThird credit card number: '{2}'", firstCreditCard, secondCreditCard, thirdCreditCard);
    }
}
