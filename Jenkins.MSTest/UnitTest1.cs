using Jenkins.Web.Services;

namespace Jenkins.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDataService service = new DataService();
            var hostName = service.GetHost();
            Assert.AreEqual(Environment.MachineName, hostName);
        }
    }
}