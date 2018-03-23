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

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();
            _mockedDialogService = new Mock<IDialogService>();

            _customerMaintenanceController = new CustomerMaintenanceController(_mockedModuleController.Object, _mockedDialogService.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillWithCustomerInfo_CustomerIsNull_ArgumentNullExceptionThrown()
        {
            var form = new CustomerMaintenanceForm(_customerMaintenanceController);
            form.FillWithCustomerInfo(null);
        }

        [TestMethod]
        public void FillWithCustomerInfo_CustomerIsValid_TextFieldsAreFilledWithCustomerInfo()
        {
            var form = new CustomerMaintenanceForm(_customerMaintenanceController);
            var customer = new Customer { Name = "Benjamin Blue", Address = "1364 Hickamore Road", City = "Blountsville", State = "Alabama", ZipCode = "35031" };

            form.FillWithCustomerInfo(customer);

            Assert.AreEqual(customer.Name, form.NameTextBox);
            Assert.AreEqual(customer.Address, form.Address);
            Assert.AreEqual(customer.City, form.City);
            Assert.AreEqual(customer.State, form.State);
            Assert.AreEqual(customer.ZipCode, form.ZipCode);
        }

        [TestMethod]
        public void ClearControls_TextFieldsAreEmpty()
        {
            var form = new CustomerMaintenanceForm(_customerMaintenanceController);
            var customer = new Customer { Name = "Benjamin Blue", Address = "1364 Hickamore Road", City = "Blountsville", State = "Alabama", ZipCode = "35031" };

            form.FillWithCustomerInfo(customer);

            form.ClearControls();

            Assert.AreEqual("", form.NameTextBox);
            Assert.AreEqual("", form.Address);
            Assert.AreEqual("", form.City);
            Assert.AreEqual("", form.State);
            Assert.AreEqual("", form.ZipCode);
        }
    }
}
