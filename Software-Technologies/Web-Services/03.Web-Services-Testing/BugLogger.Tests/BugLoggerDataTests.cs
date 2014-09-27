namespace BugLogger.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    using BugLogger.Data;
    using BugLogger.Data.Repositories;
    using BugLogger.Models;

    [TestClass]
    public class BugLoggerDataTests
    {
        private IBugLoggerData data;

        [TestInitialize]
        public void TestInit()
        {
            this.data = new BugLoggerData(new BugLoggerDbContext());
        }

        [TestMethod]
        public void GetBugsRepo_WhenGetBugsRepo_TypeShouldByGenericRepoOfBug()
        {
            var bugsRepository = this.data.Bugs;

            var type = typeof(GenericRepository<Bug>);
            var typeOfBugsRepo = bugsRepository.GetType();

            Assert.AreEqual(type, typeOfBugsRepo);
        }
    }
}