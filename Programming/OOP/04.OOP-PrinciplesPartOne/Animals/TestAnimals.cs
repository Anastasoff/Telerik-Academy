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
        public static void CalculateAverageAge(List<Animal> animals)
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
                new Dog(22, "Sharo", Sex.male),
                new Dog(17, "Sara", Sex.female),
                new Dog(14, "Bobcho", Sex.male),
                new Dog(4, "Roska", Sex.female),
                new Frog(1, "Milko", Sex.male),
                new Frog(4, "Boko", Sex.male),
                new Kitten(2, "Bochka"), 
                new Kitten(2, "Chochka"),
                new Tomcat(11, "Tom"), 
                new Tomcat(15, "Garfield")
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
