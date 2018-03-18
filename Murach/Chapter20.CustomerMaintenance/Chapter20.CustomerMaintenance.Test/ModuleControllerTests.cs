using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter20.CustomerMaintenance.Test
{
    [TestClass]
    public class ModuleControllerTests
    {
        private ModuleController _controller;

        [TestInitialize]
        public void Initialize()
        {
            _controller = new ModuleController();

            _controller.Run();
        }

        [TestMethod]
        public void GetView_CustomerMaintenanceForm_ReturnCustomerMaintenanceForm()
        {
            var result = _controller.GetView<ICustomerMaintenanceView>();

            Assert.AreEqual(result.GetType(), typeof(CustomerMaintenanceForm));
        }

        [TestMethod]
        public void GetView_AddModifyCustomerForm_ReturnAddModifyCustomerForm()
        {
            var result = _controller.GetView<IAddModifyCustomerView>();

            Assert.AreEqual(result.GetType(), typeof(AddModifyCustomerForm));
        }

        [TestMethod]
        public void GetService_ProgramFlowManager_ReturnProgramFlowManager()
        {
            var result = _controller.GetService<IProgramFlowManager>();

            Assert.AreEqual(result.GetType(), typeof(ProgramFlowManager));
        }

        [TestMethod]
        public void GetCollection_DatabaseObjectCollection_ReturnDatabaseObjectCollection()
        {
            var result = _controller.GetCollection<IDatabaseObjectCollection>();

            Assert.AreEqual(result.GetType(), typeof(DatabaseObjectCollection));
        }
    }
}
