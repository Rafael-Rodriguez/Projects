using System;
using System.Linq;
using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class AddModifyCustomerController : Controller<AddModifyCustomerForm>
    {
        public AddModifyCustomerController(IModuleController moduleController)
            :base(moduleController) { }

        public void OnLoad()
        {
            var states = GetStatesDbo().GetStates();
            View.FillStateComboBox(states.Select(state => state.StateName).ToArray());
        }

        public void OnAcceptButtonClicked(NewCustomerEventArgs eventArgs)
        {
            if (!IsValid(eventArgs))
            {
                MessageBox.Show(Resources.InvalidCustomerEntry, Resources.InvalidEntryTitle,MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                State = ConvertToStateCode(eventArgs.State),
                ZipCode = eventArgs.ZipCode
            };


            return customer;
        }

        private string ConvertToStateCode(string stateName)
        {
            var states = GetStatesDbo().GetStates();
            return states.First(state => state.StateName == stateName).StateCode;
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
