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
            : base(moduleController)
        {
            _states = GetStatesDbo().GetStates().ToList();
        }

        public void OnLoad(Customer customer)
        {
            View.FillStateComboBox(_states.Select(state => state.StateName).ToArray());

            if (customer != null)
            {
                View.Customer = customer;
            }
        }

        public void OnAcceptButtonClicked(Customer oldCustomer, Customer newCustomer)
        {
            if (!IsValid(oldCustomer) || !IsValid(newCustomer))
            {
                MessageBox.Show(Resources.InvalidCustomerEntry, Resources.InvalidEntryTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerUpdated = GetCustomerDbo().UpdateCustomer(oldCustomer, newCustomer);
            if (!customerUpdated)
            {
                MessageBox.Show(Resources.ErrorOccurredWhileUpdatingCustomer,Resources.UnableToUpdateCustomer, MessageBoxButtons.OK, MessageBoxIcon.Error);
                View.DialogResult = DialogResult.Retry;

                return;
            }

            View.Customer = newCustomer;

            View.DialogResult = DialogResult.OK;
        }

        public string ConvertStateCodeToStateName(string stateCode)
        {
            return _states.First(state => state.StateCode == stateCode).StateName;
        }

        private bool IsValid(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer?.Address) 
                && !string.IsNullOrEmpty(customer.City) 
                && !string.IsNullOrEmpty(customer.Name) 
                && !string.IsNullOrEmpty(customer.State) 
                && !string.IsNullOrEmpty(customer.ZipCode))
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
