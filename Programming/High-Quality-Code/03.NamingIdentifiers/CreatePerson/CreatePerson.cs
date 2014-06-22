namespace CreatePerson
{
    internal class PersonFactory
    {
        public Person CreatePerson(string name, int? age, Gender gender)
        {
            Person person = new Person(name, age, gender);
            return person;
        }
    }
}