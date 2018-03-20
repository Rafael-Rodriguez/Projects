using Chapter20.CustomerMaintenance.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter20.CustomerMaintenance.Test.Database
{
    [TestClass]
    public class CustomerDboTests
    {
        private CustomerDbo _customerDbo;

        [TestInitialize]
        public void Initialize()
        {
            _customerDbo = new CustomerDbo();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
