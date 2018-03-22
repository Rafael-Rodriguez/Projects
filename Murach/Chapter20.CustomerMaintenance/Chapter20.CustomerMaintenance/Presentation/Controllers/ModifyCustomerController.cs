using System;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class ModifyCustomerController : Controller<ModifyCustomerForm>
    {
        private List<State> _states = new List<State>();

        public ModifyCustomerController(IModuleController moduleController)
            :base(moduleController) { }

        public void OnLoad(CustomerEventArgs customerEventArgs)
        {
            _states = GetStatesDbo().GetStates().ToList();

            View.FillStateComboBox(_states.Select(state => state.StateName).ToArray());

            if (customerEventArgs != null && customerEventArgs.Customer != null)
            {
                var originalCustomer = customerEventArgs.Customer;
                View.FillCustomerInfo(
                    new CustomerEventArgs(
                        new Customer()
                        {
                            Name = originalCustomer.Name,
                            Address = originalCustomer.Address,
                            City = originalCustomer.City,
                            State = ConvertStateCodeToStateName(originalCustomer.State),
                            ZipCode = originalCustomer.ZipCode
                        }));
            }
        }

        public void OnAcceptButtonClicked(CustomerEventArgs eventArgs)
        {
            if (!IsValid(eventArgs))
            {
                MessageBox.Show(Resources.InvalidCustomerEntry, Resources.InvalidEntryTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetCustomerDbo().UpdateCustomer(customer);

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

        private bool IsValid(CustomerEventArgs eventArgs)
        {
            if (eventArgs != null &&
                eventArgs.Customer != null &&
                !String.IsNullOrEmpty(eventArgs.Customer.Address) &&
                !String.IsNullOrEmpty(eventArgs.Customer.City) &&
                !String.IsNullOrEmpty(eventArgs.Customer.Name) &&
                !String.IsNullOrEmpty(eventArgs.Customer.State) &&
                !String.IsNullOrEmpty(eventArgs.Customer.ZipCode))
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
