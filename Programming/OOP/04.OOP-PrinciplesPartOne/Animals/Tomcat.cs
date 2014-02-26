namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.male)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Mrrrr");
        }
    }
}