namespace Computers.HardwareComponents
{
    using System;

    using Contracts;

    public class VideoCard : IVideoCard
    {
        private const ConsoleColor Colorful = ConsoleColor.Green;
        private const ConsoleColor Monochrome = ConsoleColor.Gray;

        public bool IsMonochrome { get; set; }

        public void Draw(string textData)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = Monochrome;
                Console.WriteLine(textData);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = Colorful;
                Console.WriteLine(textData);
                Console.ResetColor();
            }
        }
    }
}