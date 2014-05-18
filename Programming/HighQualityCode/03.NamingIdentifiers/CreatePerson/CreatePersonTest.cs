namespace CreatePerson
{
    using System;

    internal class CreatePersonTest
    {
        public static void Main()
        {
            PersonFactory factory = new PersonFactory();

            Person theOneAndOnly = factory.CreatePerson("Батката", 27, Gender.Male);
            Console.WriteLine(theOneAndOnly);

            Person sheIsTheWoman = factory.CreatePerson("Мацето", 26, Gender.Female);
            Console.WriteLine(sheIsTheWoman);
        }
    }
}