using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Presentation.Controllers;

namespace Chapter20.CustomerMaintenance.Test.Views
{
    [TestClass]
    public class CustomerMaintenanceFormTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillWithCustomerInfo_CustomerIsNull_ArgumentNullExceptionThrown()
        {
            var mockedModuleController = new Mock<IModuleController>();
            var controller = new CustomerMaintenanceController(mockedModuleController.Object);

            var form = new CustomerMaintenanceForm(controller);
            form.FillWithCustomerInfo(null);


        }
    }
}
