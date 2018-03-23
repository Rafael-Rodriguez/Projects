using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class CustomerMaintenanceController : Controller<ICustomerMaintenanceView>
    {
        public CustomerMaintenanceController(IModuleController moduleController, IDialogService dialogService)
            : base(moduleController, dialogService) { }

        public void OnGetCustomerButtonClicked(string customerIdText)
        {
            if (!IsValidCustomerId(customerIdText))
            {
                DialogService.ShowMessageBox(
                    Resources.InvalidCustomerIDErrorMessage,
                    Resources.InvalidEntryTitle);

                View.SetFocusOnCustomerIdTextBox();
                return;
            }

            GetCustomerInfo(customerIdText);
        }

        public void OnAddButtonClicked()
        {
            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.AddNewCustomer();
        }

        public void OnModifyButtonClicked(ICustomer customer)
        {
            if (customer == null)
            {
                DialogService.ShowMessageBox(
                    Resources.NoCustomerInformationErrorMessage,
                    Resources.NoCustomerInformationTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                View.SetFocusOnCustomerIdTextBox();
                return;
            }

            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.ModifyExistingCustomer(customer);
        }

        public void OnDeleteButtonClicked(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void GetCustomerInfo(string text)
        {
            if(text == null)
            {
                throw new ArgumentNullException(text);
            }

            var customerId = ParseCustomerId(text);

            var customer = GetCustomerDbo().GetCustomer(customerId);

            if (customer != null)
            {
                try
                {
                    View.FillWithCustomerInfo(customer);
                }
                catch (ArgumentNullException)
                {
                    DialogService.ShowMessageBox(
                        Resources.InvalidCustomerIDErrorMessage, 
                        Resources.InvalidCustomerIDTitle);

                    View.SetFocusOnCustomerIdTextBox();
                }
            }
            else
            {
                View.ClearControls();
            }
        }

        private static bool IsValidCustomerId(string text)
        {
            int resultingNumber;
            if (text != null && int.TryParse(text, out resultingNumber))
            {
                return true;
            }

            return false;
        }
        
        private int ParseCustomerId(string text)
        {
            if(!IsValidCustomerId(text))
            {
                throw new ArgumentException("Text is not a valid customer ID", "text");
            }

            return int.Parse(text);
        }

        private ICustomerDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<ICustomerDbo>();
        }

        protected override void Dispose(bool disposing)
        {    
        }
    }
}
