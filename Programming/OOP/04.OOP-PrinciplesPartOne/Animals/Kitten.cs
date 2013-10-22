namespace Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.female;
        }

        public override void Sound()
        {
            Console.WriteLine("Myauu");
        }
    }
}
