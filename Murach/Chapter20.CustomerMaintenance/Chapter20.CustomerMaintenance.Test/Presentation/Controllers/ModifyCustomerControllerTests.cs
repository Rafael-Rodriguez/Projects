using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Test.Presentation.Controllers
{
    [TestClass]
    public class ModifyCustomerControllerTests
    {
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<IModuleController> _mockedModuleController;
        private Mock<IStatesDbo> _mockedStatesDbo;
        private Mock<IDialogService> _mockedDialogService;
        private Mock<ICustomerDbo> _mockedCustomerDbo;
        private ModifyCustomerController _controller;
        private Mock<IModifyCustomerView> _mockedModifyCustomerView;

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();

            _mockedDialogService = new Mock<IDialogService>();

            _mockedDatabaseObjectCollection = new Mock<IDatabaseObjectCollection>();

            _mockedStatesDbo = new Mock<IStatesDbo>();

            _mockedStatesDbo.Setup(dbo => dbo.GetStates()).Returns(new List<State>());

            _mockedCustomerDbo = new Mock<ICustomerDbo>();
            
            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<IStatesDbo>()).Returns(_mockedStatesDbo.Object);
            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<ICustomerDbo>()).Returns(_mockedCustomerDbo.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetCollection<IDatabaseObjectCollection>()).Returns(_mockedDatabaseObjectCollection.Object);

            _mockedModifyCustomerView = new Mock<IModifyCustomerView>();

            _controller = new ModifyCustomerController(_mockedModuleController.Object, _mockedDialogService.Object);

            _controller.View = _mockedModifyCustomerView.Object;
        }

        [TestMethod]
        public void OnLoad_CustomerIsNull_ViewCustomerIsNotSet()
        {
            _controller.OnLoad(null);

            _mockedModifyCustomerView.VerifySet(view => view.Customer = It.IsAny<Customer>(), Times.Never);
        }

        [TestMethod]
        public void OnLoad_CustomerIsValid_ViewCustomerIsSet()
        {
            var customer = new Mock<ICustomer>();

            _controller.OnLoad(customer.Object);

            _mockedModifyCustomerView.VerifySet(view => view.Customer = customer.Object, Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_OldCustomerIsNullNewCustomerIsNull_ErrorMessageBoxIsShown()
        {
            var oldCustomer = new Mock<ICustomer>();
            var newCustomer = new Mock<ICustomer>();

            _controller.OnAcceptButtonClicked(oldCustomer.Object, newCustomer.Object);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_OldCustomerAndNewCustomerAreValid_UpdateCustomerIsCalled()
        {
            var oldCustomer = CreateCustomer();
            var newCustomer = CreateCustomer();

            _controller.OnAcceptButtonClicked(oldCustomer, newCustomer);

            _mockedCustomerDbo.Verify(customerDbo => customerDbo.UpdateCustomer(oldCustomer, newCustomer), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_OldCustomerAndNewCustomerAreValid_UpdateCustomerIsCalledAndReturnsFalse_MessageBoxIsShown()
        {
            var oldCustomer = CreateCustomer();
            var newCustomer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.UpdateCustomer(oldCustomer, newCustomer)).Returns(false);

            _controller.OnAcceptButtonClicked(oldCustomer, newCustomer);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_OldCustomerAndNewCustomerAreValid_UpdateCustomerIsCalledAndReturnsTrue_ViewCustomerIsUpdatedToNewCustomer()
        {
            var oldCustomer = CreateCustomer();
            var newCustomer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.UpdateCustomer(oldCustomer, newCustomer)).Returns(true);

            _mockedModifyCustomerView.SetupProperty(view => view.Customer);
            _controller.OnAcceptButtonClicked(oldCustomer, newCustomer);

            _mockedModifyCustomerView.VerifySet(view => view.Customer = newCustomer, Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_OldCustomerAndNewCustomerAreValid_UpdateCustomerIsCalledAndReturnsTrue_ViewCustomerIdMatchesOldCustomerId()
        {
            var oldCustomer = CreateCustomer();
            var newCustomer = CreateCustomer();

            oldCustomer.CustomerId = 100;

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.UpdateCustomer(oldCustomer, newCustomer)).Returns(true);

            _mockedModifyCustomerView.SetupProperty(view => view.Customer);
            _controller.OnAcceptButtonClicked(oldCustomer, newCustomer);

            Assert.AreEqual(_mockedModifyCustomerView.Object.Customer.CustomerId, oldCustomer.CustomerId);
        }

        private ICustomer CreateCustomer()
        {
            return new Customer
            {
                Name = "Joe Blow",
                Address = "Nevermind Blvd",
                City = "Nowhere",
                State = "Nohow",
                ZipCode = "99999"
            };
        }
    }
}
