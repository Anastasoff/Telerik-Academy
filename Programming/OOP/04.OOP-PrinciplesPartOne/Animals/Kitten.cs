namespace Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.female)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Myauu");
        }
    }
}