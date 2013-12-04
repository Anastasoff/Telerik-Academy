/* 3. A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console. */

using System;

class CompanyInformation
{
    static void Main()
    {
        // Company:
        Console.WriteLine("Company information.");

        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine(); // empty line

        // Manager
        Console.WriteLine("Manager information.");

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Enter manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine(); // empty line

        Console.WriteLine("Company information: {0}, {1}, GSM: {2}, Fax: {3}, {4}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite);
        Console.WriteLine();
        Console.WriteLine("Manager information: {0} {1}, Age: {2}, GSM: {3}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);


    }
}
