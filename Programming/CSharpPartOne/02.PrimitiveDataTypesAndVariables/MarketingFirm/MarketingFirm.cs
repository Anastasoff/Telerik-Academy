using System;

// 10. A marketing firm wants to keep record of its employees. 
// Each record would have the following characteristics 
// – first name, family name, age, gender (m or f), ID number, unique employee number (27 560 000 to 27 569 999). 
// Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
class MarketingFirm
{
    static void Main()
    {
        string firstName = "Pesho";
        string lastName = "Peshev";
        byte age = 33;
        bool isMale = true;
        string numberID = "4893BHHQWK784";
        uint employeeNumber = 27569999;

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", isMale ? "male" : "female");
        Console.WriteLine("ID number: {0}", numberID);
        Console.WriteLine("Employee number: {0}", employeeNumber);
    }
}
