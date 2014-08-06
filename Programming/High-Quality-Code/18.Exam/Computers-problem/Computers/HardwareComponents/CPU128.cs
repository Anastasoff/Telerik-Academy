namespace Computers.HardwareComponents
{
    using Contracts;

    public class CPU128 : CPU
    {
        public CPU128(byte numberOfCores, byte numberOfBits, RAM ram, IVideoCard videoCard)
            : base(numberOfCores, 128, ram, videoCard)
        {
        }
    }
}