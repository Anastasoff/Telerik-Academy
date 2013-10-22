namespace Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override void Sound()
        {
            Console.WriteLine("Bau-bau!");
        }
    }
}
