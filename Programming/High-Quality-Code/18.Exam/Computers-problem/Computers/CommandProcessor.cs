namespace Computers
{
    using System;

    using AbstractFactory;

    public class CommandProcessor
    {
        public void Start()
        {
            Computer pc = null;
            Computer laptop = null;
            Computer server = null;

            var inputManufacturer = Console.ReadLine();
            if (inputManufacturer == "HP")
            {
                pc = new HPFactory().ManufacturePC();
                server = new HPFactory().ManufactureServer();
                laptop = new HPFactory().ManufactureLaptop();
            }
            else if (inputManufacturer == "Dell")
            {
                pc = new DellFactory().ManufacturePC();
                server = new DellFactory().ManufactureServer();
                laptop = new DellFactory().ManufactureLaptop();
            }
            else if (inputManufacturer == "Lenovo")
            {
                pc = new LenovoFactory().ManufacturePC();
                server = new LenovoFactory().ManufactureServer();
                laptop = new LenovoFactory().ManufactureLaptop();
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var inputCommand = Console.ReadLine();

                if (inputCommand == null)
                {
                    return;
                }

                if (inputCommand.StartsWith("Exit"))
                {
                    return;
                }

                var currentTextLine = inputCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (currentTextLine.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var command = currentTextLine[0];
                var parameter = int.Parse(currentTextLine[1]);

                if (command == "Charge")
                {
                    laptop.ChargeBattery(parameter);
                }
                else if (command == "Process")
                {
                    server.Process(parameter);
                }
                else if (command == "Play")
                {
                    pc.Play(parameter);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}