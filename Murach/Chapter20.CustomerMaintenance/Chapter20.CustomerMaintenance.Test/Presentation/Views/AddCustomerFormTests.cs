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

namespace Chapter20.CustomerMaintenance.Test.Presentation.Views
{
    [TestClass]
    public class AddCustomerFormTests
    {
        private AddCustomerController _addCustomerController;
        private Mock<IDialogService> _mockedDialogService;
        private Mock<IModuleController> _mockedModuleController;
        private IAddCustomerView _view;
        private Mock<IDatabaseObjectCollection> _mockedDatabaseObjectCollection;
        private Mock<ICustomerDbo> _mockedCustomerDbo;
        private Mock<IStatesDbo> _mockedStatesDbo;

        [TestInitialize]
        public void Initialize()
        {
            _mockedModuleController = new Mock<IModuleController>();
            _mockedDialogService = new Mock<IDialogService>();

            _mockedDatabaseObjectCollection = new Mock<IDatabaseObjectCollection>();

            _mockedCustomerDbo = new Mock<ICustomerDbo>();

            _mockedStatesDbo = new Mock<IStatesDbo>();
            _mockedStatesDbo.Setup(dbo => dbo.GetStates()).Returns(
                new List<State>() { new State { StateName = "New Jersey", StateCode = "NJ" } });

            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<ICustomerDbo>()).Returns(_mockedCustomerDbo.Object);
            _mockedDatabaseObjectCollection.Setup(databaseObjectCollection => databaseObjectCollection.GetDbo<IStatesDbo>()).Returns(_mockedStatesDbo.Object);

            _mockedModuleController.Setup(moduleController => moduleController.GetCollection<IDatabaseObjectCollection>()).Returns(_mockedDatabaseObjectCollection.Object);

            _addCustomerController = new AddCustomerController(_mockedModuleController.Object, _mockedDialogService.Object);

            _view = new AddCustomerForm(_addCustomerController);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillStateComboBox_StatesIsNull_ArgumentNullException()
        {
            _view.FillStateComboBox(null);
        }

        [TestMethod]
        public void FillStateComboBox_ArrayOfStateCodes_ComboBoxContainsStateCode()
        {
            var states = new string[] { "NJ", "NH", "NM" };

            _view.FillStateComboBox(states);

            Assert.AreEqual(_view.States.Count, states.Length);
            Assert.AreEqual(_view.States[0], states[0]);
            Assert.AreEqual(_view.States[1], states[1]);
            Assert.AreEqual(_view.States[2], states[2]);
        }

    }
}
