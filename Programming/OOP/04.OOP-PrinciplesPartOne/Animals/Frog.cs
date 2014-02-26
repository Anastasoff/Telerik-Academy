namespace Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Kvak-kvak!");
        }
    }
}