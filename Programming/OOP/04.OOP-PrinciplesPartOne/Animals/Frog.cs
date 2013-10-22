namespace Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override void Sound()
        {
            Console.WriteLine("Kvak-kvak!");
        }
    }
}
