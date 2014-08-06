
namespace Computers.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Computers.HardwareComponents;

    [TestClass]
    public class CPUTests
    {
        private CPU testCPU;

        [TestInitialize]
        public void InitLaptopBattery()
        {
            this.testCPU = new CPU(2, 32, new RAM(2), new VideoCard());
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
