using System;
using System.Linq;
using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;
using System.Collections.Generic;
using Chapter20.CustomerMaintenance.Services;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class AddCustomerController : Controller<AddCustomerForm>
    {
        private List<State> _states = new List<State>();

        public AddCustomerController(IModuleController moduleController, IDialogService dialogService)
            :base(moduleController, dialogService) { }

        public void OnLoad()
        {
            _states = GetStatesDbo().GetStates().ToList();

            View.FillStateComboBox(_states.Select(state => state.StateName).ToArray());
        }

        public void OnAcceptButtonClicked(NewCustomerEventArgs eventArgs)
        {
            if (!IsValid(eventArgs))
            {
                DialogService.ShowMessageBox(
                    Resources.InvalidCustomerEntry, 
                    Resources.InvalidEntryTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var customer = CreateCustomer(eventArgs);

            customer.CustomerId = GetCustomerDbo().AddCustomer(customer);

            View.Customer = customer;

            View.DialogResult = DialogResult.OK;
        }

        private Customer CreateCustomer(NewCustomerEventArgs eventArgs)
        {
            var customer = new Customer
            {
                Address = eventArgs.Address,
                City = eventArgs.City,
                Name = eventArgs.Name,
                State = ConvertStateNameToStateCode(eventArgs.State),
                ZipCode = eventArgs.ZipCode
            };


            return customer;
        }

        private string ConvertStateNameToStateCode(string stateName)
        {
            return _states.First(state => state.StateName == stateName).StateCode;
        }

        private string ConvertStateCodeToStateName(string stateCode)
        {
            return _states.First(state => state.StateCode == stateCode).StateName;
        }

        private bool IsValid(NewCustomerEventArgs eventArgs)
        {
            if( eventArgs != null &&
                !String.IsNullOrEmpty(eventArgs.Address) &&
                !String.IsNullOrEmpty(eventArgs.City) &&
                !String.IsNullOrEmpty(eventArgs.Name) &&
                !String.IsNullOrEmpty(eventArgs.State) &&
                !String.IsNullOrEmpty(eventArgs.ZipCode))
            {
                return true;
            }

            return false;
        }

        public void OnCancelButtonClicked()
        {

        }

        protected override void Dispose(bool disposing)
        {
            
        }

        private StatesDbo GetStatesDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<StatesDbo>();
        }

        private CustomerDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<CustomerDbo>();
        }
    }
}
