namespace Contracts
{
    public interface IBattery
    {
        int Percentage { get; set; }

        void Charge(int chargeAmount);
    }
}