namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.male;
        }

        public override void Sound()
        {
            Console.WriteLine("Mrrrr");
        }
    }
}
