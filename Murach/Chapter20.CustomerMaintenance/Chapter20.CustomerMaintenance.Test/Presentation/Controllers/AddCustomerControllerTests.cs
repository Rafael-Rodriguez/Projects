using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Test.Presentation.Controllers
{
    [TestClass]
    public class AddCustomerControllerTests
    {
        private AddCustomerController _controller;
        private Mock<IAddCustomerView> _mockedAddCustomerView;
        private Mock<ICustomerDbo> _mockedCustomerDbo;
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<IDialogService> _mockedDialogService;
        private Mock<IModuleController> _mockedModuleController;
        private Mock<IStatesDbo> _mockedStatesDbo;

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();

            _mockedDialogService = new Mock<IDialogService>();

            _mockedAddCustomerView = new Mock<IAddCustomerView>();

            _mockedDatabaseObjectCollection = new Mock<IDatabaseObjectCollection>();

            _mockedCustomerDbo = new Mock<ICustomerDbo>();

            _mockedStatesDbo = new Mock<IStatesDbo>();
            _mockedStatesDbo.Setup(dbo => dbo.GetStates()).Returns(
                new List<State>() { new State { StateName = "New Jersey", StateCode = "NJ" } });

            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<ICustomerDbo>()).Returns(_mockedCustomerDbo.Object);
            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<IStatesDbo>()).Returns(_mockedStatesDbo.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetCollection<IDatabaseObjectCollection>()).Returns(_mockedDatabaseObjectCollection.Object);


            _controller = new AddCustomerController(_mockedModuleController.Object, _mockedDialogService.Object);

            _controller.View = _mockedAddCustomerView.Object;
        }

        [TestMethod]
        public void OnLoad_ViewStateComboBoxIsFilled()
        {
            _controller.OnLoad();

            _mockedAddCustomerView.Verify(view => view.FillStateComboBox(It.IsAny<string[]>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OnAcceptButtonClicked_NewCustomerArgsIsNull_ArgumentNullExceptionIsThrown()
        {
            _controller.OnAcceptButtonClicked(null);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_NewCustomerArgsIsNotValid_MessageBoxIsShown()
        {
            var customerArgs = CreateCustomerArgs();
            customerArgs.Address = null;

            _controller.OnAcceptButtonClicked(customerArgs);

            _mockedDialogService.Verify(dialogService => dialogService.ShowMessageBox(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<MessageBoxButtons>(), MessageBoxIcon.Error));
        }

        [TestMethod]
        public void OnAcceptButtonClicked_NewCustomerArgsIsValid_AddCustomerIsCalled()
        {
            var customerArgs = CreateCustomerArgs();

            _controller.OnAcceptButtonClicked(customerArgs);

            _mockedCustomerDbo.Verify(customerDbo => customerDbo.AddCustomer(It.IsAny<ICustomer>()), Times.Once);
        }

        [TestMethod]
        public void OnAcceptButtonClicked_NewCustomerArgsIsValid_ViewCustomerIsSetWithNewlyCreatedCustomer()
        {
            var customerArgs = CreateCustomerArgs();

            _controller.OnAcceptButtonClicked(customerArgs);

            _mockedCustomerDbo.Setup(customerDbo => customerDbo.AddCustomer(It.IsAny<ICustomer>())).Returns(1);

            _mockedAddCustomerView.VerifySet(view => view.Customer = It.IsAny<ICustomer>(), Times.Once);
        }

        private NewCustomerArgs CreateCustomerArgs()
        {
            return new NewCustomerArgs
            (
                name: "Joe Blow",
                address: "Nevermind Blvd",
                city: "Nowhere",
                state: "New Jersey",
                zipCode: "99999"
            );
        }
    }
}
