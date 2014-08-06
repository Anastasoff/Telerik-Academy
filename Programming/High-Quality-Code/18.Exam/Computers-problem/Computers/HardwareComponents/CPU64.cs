namespace Computers.HardwareComponents
{
    using Contracts;

    public class CPU64 : CPU
    {
        public CPU64(byte numberOfCores, byte numberOfBits, RAM ram, IVideoCard videoCard)
            : base(numberOfCores, 64, ram, videoCard)
        {
        }
    }
}