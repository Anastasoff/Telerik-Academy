namespace Animals
{
    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public abstract void Sound();

        public override string ToString()
        {
            return string.Format("Age: {0}, name: {1}, sex: {2}", this.Age, this.Name, this.Sex);
        }
    }
}