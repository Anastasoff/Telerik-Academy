namespace MenuOfLists
{
    using System.Drawing;

    public class MenuOption
    {
        public MenuOption(string name, string url)
        {
            this.Name = name;
            this.Url = url;
            this.FontColor = Color.Blue;
        }

        public string Name { get; set; }

        public string Url { get; set; }

        public Color FontColor { get; set; }
    }
}