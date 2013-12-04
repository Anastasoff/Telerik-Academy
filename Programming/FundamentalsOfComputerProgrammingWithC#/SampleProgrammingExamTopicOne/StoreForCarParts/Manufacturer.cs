namespace StoreForCarParts
{
    public class Manufacturer
    {
        private string name;
        private string country;
        private string address;
        private string phoneNumber;
        private string email;

        public Manufacturer(string name, string country, string address, string phoneNumber, string email)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public override string ToString()
        {
            return this.name + " <" + this.country + "," + this.address + "," + this.phoneNumber + "," + this.email + ">";
        }
    }
}
