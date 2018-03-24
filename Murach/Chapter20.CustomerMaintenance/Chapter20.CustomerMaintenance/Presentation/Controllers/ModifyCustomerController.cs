using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Collections;
using System.Collections.Generic;
using System.Linq;
using Chapter20.CustomerMaintenance.Services;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class ModifyCustomerController : Controller<IModifyCustomerView>
    {
        private List<State> _states = new List<State>();

        public ModifyCustomerController(IModuleController moduleController, IDialogService dialogService)
            : base(moduleController, dialogService)
        {
            _states = GetStatesDbo().GetStates().ToList();
        }

        public void OnLoad(ICustomer customer)
        {
            View.FillStateComboBox(_states.Select(state => state.StateName).ToArray());

            if (customer != null)
            {
                View.Customer = customer;
            }
        }

        public void OnAcceptButtonClicked(ICustomer oldCustomer, ICustomer newCustomer)
        {
            if (!IsValid(oldCustomer) || !IsValid(newCustomer))
            {
                DialogService.ShowMessageBox(Resources.InvalidCustomerEntry, Resources.InvalidEntryTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerUpdated = GetCustomerDbo().UpdateCustomer(oldCustomer, newCustomer);
            if (!customerUpdated)
            {
                DialogService.ShowMessageBox(Resources.ErrorOccurredWhileUpdatingCustomer, Resources.UnableToUpdateCustomer, MessageBoxButtons.OK, MessageBoxIcon.Error);
                View.SetDialogResult(DialogResult.Retry);

                return;
            }

            View.Customer = newCustomer;

            View.SetDialogResult(DialogResult.OK);
        }

        public void OnCancelButtonClicked()
        {

        }

        public string ConvertStateCodeToStateName(string stateCode)
        {
            return _states.First(state => state.StateCode == stateCode).StateName;
        }

        private bool IsValid(ICustomer customer)
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
