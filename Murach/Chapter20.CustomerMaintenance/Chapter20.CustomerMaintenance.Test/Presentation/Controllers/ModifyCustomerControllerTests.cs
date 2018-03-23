using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Chapter20.CustomerMaintenance.Test.Presentation.Controllers
{
    [TestClass]
    public class ModifyCustomerControllerTests
    {
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<IModuleController> _mockedModuleController;
        private Mock<IStatesDbo> _mockedStatesDbo;

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();

            _mockedDatabaseObjectCollection = new Mock<IDatabaseObjectCollection>();

            _mockedStatesDbo = new Mock<IStatesDbo>();

            _mockedStatesDbo.Setup(dbo => dbo.GetStates()).Returns(new List<State>());

            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<IStatesDbo>()).Returns(_mockedStatesDbo.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetCollection<IDatabaseObjectCollection>()).Returns(_mockedDatabaseObjectCollection.Object);
        }

        [TestMethod]
        public void OnLoad_CustomerIsNull_ViewCustomerIsNotSet()
        {
            var controller = new ModifyCustomerController(_mockedModuleController.Object);
            var form = new Mock<IModifyCustomerView>();

            controller.View = form.Object;

            //var customer = new Mock<ICustomer>();

            controller.OnLoad(null);

            form.Verify(view => view.Customer, Times.Never);
        }
    }
}
