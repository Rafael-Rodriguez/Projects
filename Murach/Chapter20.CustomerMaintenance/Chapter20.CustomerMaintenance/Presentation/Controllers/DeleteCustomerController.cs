using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Properties;
using Chapter20.CustomerMaintenance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public class DeleteCustomerController : Controller<IDeleteCustomerView>
    {
        private List<State> _states = new List<State>();

        public DeleteCustomerController(IModuleController moduleController, IDialogService dialogService) 
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

        public void OnAcceptButtonClicked(ICustomer customer)
        {
            if (!IsValid(customer))
            {
                DialogService.ShowMessageBox(Resources.InvalidCustomerEntry, Resources.InvalidEntryTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customerDeleted = GetCustomerDbo().DeleteCustomer(customer);
            if (!customerDeleted)
            {
                DialogService.ShowMessageBox(Resources.ErrorOccurredWhileDeletingCustomer, Resources.UnableToDeleteCustomer, MessageBoxButtons.OK, MessageBoxIcon.Error);
                View.SetDialogResult(DialogResult.Retry);

                return;
            }

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
            if(customer == null)
            {
                throw new ArgumentNullException("customer");
            }

            if (!string.IsNullOrEmpty(customer.Address)
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
