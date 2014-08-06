namespace Computers.AbstractFactory
{
    public abstract class AbstractComputerFactory
    {
        public abstract Computer ManufacturePC();

        public abstract Computer ManufactureServer();

        public abstract Computer ManufactureLaptop();
    }
}