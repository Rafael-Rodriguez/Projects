using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Services;

namespace Chapter20.CustomerMaintenance.Test.Views
{
    [TestClass]
    public class CustomerMaintenanceFormTests
    {
        Mock<IModuleController> _mockedModuleController;
        CustomerMaintenanceController _customerMaintenanceController;
        private Mock<IDialogService> _mockedDialogService;
        private ICustomerMaintenanceView _view;

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();
            _mockedDialogService = new Mock<IDialogService>();

            _customerMaintenanceController = new CustomerMaintenanceController(_mockedModuleController.Object, _mockedDialogService.Object);

            _view = new CustomerMaintenanceForm(_customerMaintenanceController);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillWithCustomerInfo_CustomerIsNull_ArgumentNullExceptionThrown()
        {
            _view.FillWithCustomerInfo(null);
        }

        [TestMethod]
        public void FillWithCustomerInfo_CustomerIsValid_TextFieldsAreFilledWithCustomerInfo()
        {
            var customer = CreateCustomer();

            _view.FillWithCustomerInfo(customer);

            Assert.AreEqual(customer.Name, _view.NameTextBox);
            Assert.AreEqual(customer.Address, _view.Address);
            Assert.AreEqual(customer.City, _view.City);
            Assert.AreEqual(customer.State, _view.State);
            Assert.AreEqual(customer.ZipCode, _view.ZipCode);
        }

        [TestMethod]
        public void ClearControls_TextFieldsAreEmpty()
        {
            var customer = CreateCustomer();

            _view.FillWithCustomerInfo(customer);

            _view.ClearControls();

            Assert.AreEqual("", _view.NameTextBox);
            Assert.AreEqual("", _view.Address);
            Assert.AreEqual("", _view.City);
            Assert.AreEqual("", _view.State);
            Assert.AreEqual("", _view.ZipCode);
        }
        
        private ICustomer CreateCustomer()
        {
            return new Customer
            {
                Name = "Benjamin Blue",
                Address = "1364 Hickamore Road",
                City = "Blountsville",
                State = "Alabama",
                ZipCode = "35031"
            };

        }
    }
}
