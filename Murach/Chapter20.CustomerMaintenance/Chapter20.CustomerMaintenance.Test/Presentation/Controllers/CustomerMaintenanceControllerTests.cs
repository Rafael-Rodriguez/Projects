using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Test.Presentation.Controllers
{
    [TestClass]
    public class CustomerMaintenanceControllerTests
    {
        private CustomerMaintenanceController _controller;
        private Mock<ICustomerDbo> _mockedCustomerDbo;
        private Mock<ICustomerMaintenanceView> _mockedCustomerMaintenanceView;
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<IDialogService> _mockedDialogService;
        private Mock<IModuleController> _mockedModuleController;
        private Mock<IProgramFlowManager> _mockedProgramFlowManager;

        [TestInitialize]
        public void Initialize()
        {

            _mockedModuleController = new Mock<IModuleController>();

            _mockedDialogService = new Mock<IDialogService>();

            _mockedCustomerMaintenanceView = new Mock<ICustomerMaintenanceView>();

            _controller = new CustomerMaintenanceController(_mockedModuleController.Object, _mockedDialogService.Object);

            _controller.View = _mockedCustomerMaintenanceView.Object;

            _mockedDatabaseObjectCollection = new Mock<IDatabaseObjectCollection>();

            _mockedProgramFlowManager = new Mock<IProgramFlowManager>();

            _mockedCustomerDbo = new Mock<ICustomerDbo>();

            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<ICustomerDbo>()).Returns(_mockedCustomerDbo.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetCollection<IDatabaseObjectCollection>()).Returns(_mockedDatabaseObjectCollection.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetService<IProgramFlowManager>()).Returns(_mockedProgramFlowManager.Object);
            
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsNull_MessageBoxIsShown()
        {
            _controller.OnGetCustomerButtonClicked(null);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsNull_ViewsFocusIsSetOnCustomerIdTextBox()
        {
            _controller.OnGetCustomerButtonClicked(null);

            _mockedCustomerMaintenanceView.Verify(view => view.SetFocusOnCustomerIdTextBox(), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsAString_MessageBoxIsShown()
        {
            var invalidCustomerID = "Tootsie";

            _controller.OnGetCustomerButtonClicked(invalidCustomerID);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsAFloat_MessageBoxIsShown()
        {
            var invalidCustomerID = "1234.34";

            _controller.OnGetCustomerButtonClicked(invalidCustomerID);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsValid_GetCustomerIsCalled()
        {
            var customerID = "123";

            _controller.OnGetCustomerButtonClicked(customerID);

            _mockedCustomerDbo.Verify(customerDbo => customerDbo.GetCustomer(int.Parse(customerID)), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsValid_GetCustomerReturnsNull_CustomerMaintenanceViewControlsAreCleared()
        {
            var customerID = "123";
            Customer nullCustomer = null;

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.GetCustomer(It.IsAny<int>())).Returns(nullCustomer);

            _controller.OnGetCustomerButtonClicked(customerID);

            _mockedCustomerMaintenanceView.Verify(view => view.ClearControls(), Times.Once);
        }

        [TestMethod]
        public void OnGetCustomerButtonClicked_CustomerIDIsValid_GetCustomerReturnsCustomer_CustomerMaintenanceViewControlsAreFilledWithCustomerInfo()
        {
            var customerID = "123";
            var customer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.GetCustomer(It.IsAny<int>())).Returns(customer);

            _controller.OnGetCustomerButtonClicked(customerID);

            _mockedCustomerMaintenanceView.Verify(view => view.FillWithCustomerInfo(customer), Times.Once);
        }

        [TestMethod]
        public void OnAddButtonClicked_AddNewCustomer()
        {
            _controller.OnAddButtonClicked();

            _mockedProgramFlowManager.Verify(programFlowManager => programFlowManager.AddNewCustomer(), Times.Once);
        }

        [TestMethod]
        public void OnModifyButtonClicked_CustomerIsNull_MessageBoxIsShown()
        {
            _controller.OnModifyButtonClicked(null);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error), Times.Once);
        }


        [TestMethod]
        public void OnModifyButtonClicked_CustomerIsValid_ModifyExistingCustomerIsCalled()
        {
            var customer = CreateCustomer();

            _controller.OnModifyButtonClicked(customer);

            _mockedProgramFlowManager.Verify(programFlowManager => programFlowManager.ModifyExistingCustomer(customer), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCustomerInfo_TextIsNull_ArgumentNullExceptionIsThrown()
        {
            _controller.GetCustomerInfo(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCustomerInfo_TextIsAString_ArgumentExceptionIsThrown()
        {
            _controller.GetCustomerInfo("string");
        }

        [TestMethod]
        public void GetCustomerInfo_CustomerIDIsValid_GetCustomerReturnsNull_CustomerMaintenanceViewControlsAreCleared()
        {
            var customerID = "123";
            Customer nullCustomer = null;

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.GetCustomer(It.IsAny<int>())).Returns(nullCustomer);

            _controller.OnGetCustomerButtonClicked(customerID);

            _mockedCustomerMaintenanceView.Verify(view => view.ClearControls(), Times.Once);
        }

        [TestMethod]
        public void GetCustomerInfo_CustomerIDIsValid_GetCustomerReturnsCustomer_CustomerMaintenanceViewControlsAreFilledWithCustomerInfo()
        {
            var customerID = "123";
            var customer = CreateCustomer();

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.GetCustomer(It.IsAny<int>())).Returns(customer);

            _controller.OnGetCustomerButtonClicked(customerID);

            _mockedCustomerMaintenanceView.Verify(view => view.FillWithCustomerInfo(customer), Times.Once);
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
