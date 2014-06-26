namespace SimpleT4Template
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Pesho";
            person.LastName = "Peshev";
            person.Age = 99;
            person.Address = "Dolno nagornishte";

            Console.WriteLine(
                "{0} {1} is {2} years old from '{3}'.",
                person.FirstName,
                person.LastName,
                person.Age,
                person.Address);
        }
    }
}