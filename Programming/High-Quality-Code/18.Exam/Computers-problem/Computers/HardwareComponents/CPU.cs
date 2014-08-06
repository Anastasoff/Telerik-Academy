namespace Computers.HardwareComponents
{
    using System;

    using Contracts;

    // TODO: This class needs refactoring :), abstract CPU with successors CPU32, CPU64, CPU128 and so on, they can use some of the functionality of the current class
    public class CPU
    {
        private byte numberOfCores;
        private byte numberOfBits;
        private RAM ram;
        private IVideoCard videoCard;

        public CPU(byte numberOfCores, byte numberOfBits, RAM ram, IVideoCard videoCard)
        {
            this.numberOfCores = numberOfCores;
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.videoCard = videoCard;
        }

        public void GenerateRandomNumber(int min, int max, Random randomGenerator)
        {
            int randomNumber = randomGenerator.Next(min, max);

            this.ram.SaveValue(randomNumber);
        }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                this.SquareNumber64();
            }

            if (this.numberOfBits == 128)
            {
                this.SquareNumber128();
            }
        }

        // TODO: code duplication
        private void SquareNumber32()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 500)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = data * data;
                string formatedResult = string.Format("Square of {0} is {1}.", data, value);
                this.videoCard.Draw(formatedResult);
            }
        }

        // TODO: code duplication
        private void SquareNumber64()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = data * data;
                string formatedResult = string.Format("Square of {0} is {1}.", data, value);
                this.videoCard.Draw(formatedResult);
            }
        }

        // TODO: code duplication
        private void SquareNumber128()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 2000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = data * data;
                string formatedResult = string.Format("Square of {0} is {1}.", data, value);
                this.videoCard.Draw(formatedResult);
            }
        }
    }
}