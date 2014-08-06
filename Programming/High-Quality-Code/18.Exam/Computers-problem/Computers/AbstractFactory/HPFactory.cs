namespace Computers.AbstractFactory
{
    using System.Collections.Generic;

    using HardwareComponents;

    public class HPFactory : AbstractComputerFactory
    {
        public override Computer ManufacturePC()
        {
            var type = ComputerType.PC;
            var ram = new RAM(2);
            var videoCard = new VideoCard() { IsMonochrome = false };
            var cpu = new CPU(2, 32, ram, videoCard);
            var singlePcHardDrive = new HardDriver(500, false, 0);
            var hardDrives = new[] { singlePcHardDrive };
            var pc = new Computer(type, cpu, ram, hardDrives, videoCard, null);

            return pc;
        }

        public override Computer ManufactureServer()
        {
            var type = ComputerType.SERVER;
            var ram = new RAM(32);
            var videoCard = new VideoCard() { IsMonochrome = true };
            var cpu = new CPU(4, 32, ram, videoCard);
            var singleServerHardDrive = new HardDriver(1000, false, 0);
            var serverInRaidHardDrives = new HardDriver(0, true, 2, new List<HardDriver> { singleServerHardDrive, singleServerHardDrive });
            var hardDrives = new List<HardDriver> { serverInRaidHardDrives };
            var server = new Computer(type, cpu, ram, hardDrives, videoCard, null);

            return server;
        }

        public override Computer ManufactureLaptop()
        {
            var type = ComputerType.LAPTOP;
            var ram = new RAM(4);
            var videoCard = new VideoCard() { IsMonochrome = false };
            var cpu = new CPU(2, 64, ram, videoCard);
            var hardDrives = new[] { new HardDriver(500, false, 0) };
            var battery = new LaptopBattery();
            var laptop = new Computer(type, cpu, ram, hardDrives, videoCard, battery);

            return laptop;
        }
    }
}