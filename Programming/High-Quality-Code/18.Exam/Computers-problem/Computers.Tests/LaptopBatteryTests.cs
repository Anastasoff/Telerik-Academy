namespace Computers.Tests
{
    using Computers.HardwareComponents;
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopBatteryTests
    {
        private IBattery testLaptopBattery;

        [TestInitialize]
        public void InitLaptopBattery()
        {
            this.testLaptopBattery = new LaptopBattery();
        }

        [TestMethod]
        public void TestInitialAmount()
        {
            int expectedAmount = 50;
            Assert.AreEqual(expectedAmount, testLaptopBattery.Percentage);
        }

        [TestMethod]
        public void TestToChargeWith100OverInitialAmount()
        {
            this.testLaptopBattery.Charge(100);
            int exprectedAmount = 100;
            Assert.AreEqual(exprectedAmount, testLaptopBattery.Percentage);
        }

        [TestMethod]
        public void TestToChargeWithNegativeAmount()
        {
            this.testLaptopBattery.Charge(-100);
            int exprectedAmount = 0;
            Assert.AreEqual(exprectedAmount, testLaptopBattery.Percentage);
        }
    }
}