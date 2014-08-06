namespace Computers
{
    using System.Collections.Generic;

    using Common;
    using Contracts;
    using HardwareComponents;

    public class Computer
    {
        private ComputerType type;
        private CPU cpu;
        private RAM ram;
        private IEnumerable<HardDriver> hardDrives;
        private IVideoCard videoCard;
        private IBattery battery;

        public Computer(ComputerType type, CPU cpu, RAM ram, IEnumerable<HardDriver> hardDrives, IVideoCard videoCard, IBattery battery)
        {
            this.type = type;
            this.cpu = cpu;
            this.ram = ram;
            this.hardDrives = hardDrives;
            this.videoCard = videoCard;
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            string batteryStatus = string.Format("Battery status: {0}%", this.battery.Percentage);
            this.videoCard.Draw(batteryStatus);
        }

        public void Play(int guessNumber)
        {
            this.cpu.GenerateRandomNumber(1, 10, RandomGenerator.GetInstance);
            var number = this.ram.LoadValue();
            if (number != guessNumber)
            {
                this.videoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.videoCard.Draw("You win!");
            }
        }

        public void Process(int data)
        {
            this.ram.SaveValue(data);
            this.cpu.SquareNumber();
        }
    }
}