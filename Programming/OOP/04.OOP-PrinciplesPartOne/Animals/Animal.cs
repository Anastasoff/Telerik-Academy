namespace Animals
{
    public abstract class Animal : ISound
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }

        public abstract void Sound();

        public override string ToString()
        {
            return string.Format("Age: {0}, name: {1}, sex: {2}", this.Age, this.Name, this.Sex);
        }
    }
}
