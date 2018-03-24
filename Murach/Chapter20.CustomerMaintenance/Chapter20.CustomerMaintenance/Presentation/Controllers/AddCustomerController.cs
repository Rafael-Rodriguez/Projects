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
    public sealed class AddCustomerController : Controller<IAddCustomerView>
    {
        private List<State> _states = new List<State>();

        public AddCustomerController(IModuleController moduleController, IDialogService dialogService)
            :base(moduleController, dialogService)
        {
            _states = GetStatesDbo().GetStates().ToList();
        }

        public void OnLoad()
        {
            View.FillStateComboBox(_states.Select(state => state.StateName).ToArray());
        }

        public void OnAcceptButtonClicked(NewCustomerArgs eventArgs)
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

            View.SetDialogResult(DialogResult.OK);
        }

        public void OnCancelButtonClicked()
        {

        }

        private ICustomer CreateCustomer(NewCustomerArgs eventArgs)
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

        private bool IsValid(NewCustomerArgs eventArgs)
        {
            if(eventArgs == null)
            {
                throw new ArgumentNullException("eventArgs");
            }

            if( !String.IsNullOrEmpty(eventArgs.Address) &&
                !String.IsNullOrEmpty(eventArgs.City) &&
                !String.IsNullOrEmpty(eventArgs.Name) &&
                !String.IsNullOrEmpty(eventArgs.State) &&
                !String.IsNullOrEmpty(eventArgs.ZipCode))
            {
                return true;
            }

            return false;
        }

        private IStatesDbo GetStatesDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<IStatesDbo>();
        }

        private ICustomerDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<ICustomerDbo>();
        }
    }
}
