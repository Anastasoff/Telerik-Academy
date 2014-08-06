namespace Computers.HardwareComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDriver
    {
        private int capacity;
        private bool isInRaid;
        private int hardDrivesInRaid;
        private List<HardDriver> hardDrives;
        private Dictionary<int, string> data;

        public HardDriver(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.capacity = capacity;
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.hardDrives = new List<HardDriver>(); // TODO: DI
            this.data = new Dictionary<int, string>(capacity); // TODO: DI
        }

        public HardDriver(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDriver> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hardDrives = hardDrives;
        }

        private int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.hardDrives.Any())
                    {
                        return 0;
                    }

                    return this.hardDrives.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        private void SaveData(int addr, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.hardDrives)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        private string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.hardDrives.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hardDrives.First().LoadData(address);
            }
            else
            {
                return this.data[address];
            }
        }
    }
}