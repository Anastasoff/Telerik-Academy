/*
3. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
Kittens and tomcats are cats. All animals are described by age, name and sex.
Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/

namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestAnimals
    {
        public static void CalculateAverageAge(IEnumerable<Animal> animals)
        {
            var sorted =
                from animal in animals
                group animal by animal.GetType().Name into groups
                select new
                {
                    Species = groups.Key,
                    AverageAge = groups.Average(x => x.Age)
                };

            foreach (var kind in sorted)
            {
                Console.WriteLine("Average age of {0}s are {1}", kind.Species, kind.AverageAge);
            }
        }

        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo", 22, Sex.male),
                new Dog("Sara", 17, Sex.female),
                new Dog("Bobcho", 14, Sex.male),
                new Dog("Roska", 4, Sex.female),
                new Frog("Milko", 1, Sex.male),
                new Frog("Boko", 4, Sex.male),
                new Kitten("Bochka", 2),
                new Kitten("Chochka", 2),
                new Tomcat("Tom", 11),
                new Tomcat("Garfield", 15)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine(new string('=', 35));

            CalculateAverageAge(animals);
        }
    }
}