namespace Computers.HardwareComponents
{
    using Contracts;

    public class LaptopBattery : IBattery
    {
        private const int InitialAmount = 50;
        private const int MinAmount = 0;
        private const int MaxAmount = 100;

        public LaptopBattery()
        {
            this.Percentage = InitialAmount;
        }

        public int Percentage { get; set; }

        public void Charge(int chargeAmount)
        {
            this.Percentage += chargeAmount;
            if (this.Percentage > MaxAmount)
            {
                this.Percentage = MaxAmount;
            }

            if (this.Percentage < MinAmount)
            {
                this.Percentage = MinAmount;
            }
        }
    }
}