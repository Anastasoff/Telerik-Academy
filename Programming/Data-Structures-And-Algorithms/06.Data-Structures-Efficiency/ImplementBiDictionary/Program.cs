using System;

namespace ImplementBiDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var biDict = new BiDictionary<string, int, Person>();
            var people = new[]
            {
            new Person() { Name = "Peter", Age = 20, City = "Sofia" },
            new Person() { Name = "Peter", Age = 20, City = "Varna" },
            new Person() { Name = "Peter", Age = 25, City = "Varna" },
            new Person() { Name = "Billy", Age = 20, City = "Sofia" },
            };

            foreach (var person in people)
            {
                biDict.Add(person.Name, person.Age, person);
            }

            Console.WriteLine("All people in the BiDictionary:");
            foreach (var triple in biDict)
            {
                Console.WriteLine(string.Join(Environment.NewLine, triple.Item3));
            }

            Console.WriteLine("All people named Peter: {0}", string.Join(", ", biDict.GetByK1("Peter")));
            Console.WriteLine("All people at age 20: {0}", string.Join(", ", biDict.GetByK2(20)));
            Console.WriteLine("All people at age 20, named Peter: {0}", string.Join(", ", biDict.GetByBoth("Peter", 20)));
        }
    }
}