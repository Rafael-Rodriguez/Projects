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
    public class DeleteCustomerControllerTests
    {
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<IModuleController> _mockedModuleController;
        private Mock<IStatesDbo> _mockedStatesDbo;
        private Mock<IDialogService> _mockedDialogService;
        private Mock<ICustomerDbo> _mockedCustomerDbo;
        private DeleteCustomerController _controller;
        private Mock<IDeleteCustomerView> _mockedDeleteCustomerView;

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

            _mockedDeleteCustomerView = new Mock<IDeleteCustomerView>();

            _controller = new DeleteCustomerController(_mockedModuleController.Object, _mockedDialogService.Object);

            _controller.View = _mockedDeleteCustomerView.Object;
        }

        [TestMethod]
        public void OnLoad_CustomerIsNull_ViewCustomerIsNotSet()
        {
            _controller.OnLoad(null);

            _mockedDeleteCustomerView.VerifySet(view => view.Customer = It.IsAny<Customer>(), Times.Never);
        }

        [TestMethod]
        public void OnLoad_CustomerIsValid_ViewCustomerIsSet()
        {
            var customer = new Mock<ICustomer>();

            _controller.OnLoad(customer.Object);

            _mockedDeleteCustomerView.VerifySet(view => view.Customer = customer.Object, Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_CustomerIsNull_ErrorMessageBoxIsShown()
        {
            var customer = new Mock<ICustomer>();

            _controller.OnAcceptButtonClicked(customer.Object);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_CustomerIsValid_DeleteCustomerIsCalled()
        {
            var customer = CreateCustomer();

            _controller.OnAcceptButtonClicked(customer);

            _mockedCustomerDbo.Verify(customerDbo => customerDbo.DeleteCustomer(customer), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_CustomerAreValid_DeleteCustomerIsCalledAndReturnsFalse_MessageBoxIsShown()
        {
            var customer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.DeleteCustomer(customer)).Returns(false);

            _controller.OnAcceptButtonClicked(customer);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_CustomerAreValid_DeleteCustomerIsCalledAndReturnsFalse_SetDialogResultIsCalledWithRetry()
        {
            var customer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.DeleteCustomer(customer)).Returns(false);

            _controller.OnAcceptButtonClicked(customer);

            _mockedDeleteCustomerView.Verify(view => view.SetDialogResult(DialogResult.Retry), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_CustomerIsValid_DeleteCustomerIsCalledAndReturnsTrue_SetDialogResultIsCalledWithOk()
        {
            var customer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.DeleteCustomer(customer)).Returns(true);

            _controller.OnAcceptButtonClicked(customer);

            _mockedDeleteCustomerView.Verify(view => view.SetDialogResult(DialogResult.OK), Times.Once);
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
