namespace Computers.HardwareComponents
{
    using Contracts;

    public class CPU32 : CPU
    {
        public CPU32(byte numberOfCores, byte numberOfBits, RAM ram, IVideoCard videoCard)
            : base(numberOfCores, 32, ram, videoCard)
        {
        }
    }
}