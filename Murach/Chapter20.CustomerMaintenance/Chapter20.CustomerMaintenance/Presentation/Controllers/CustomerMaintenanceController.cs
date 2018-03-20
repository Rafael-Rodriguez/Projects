using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Properties;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class CustomerMaintenanceController : Controller<CustomerMaintenanceForm>
    {
        public CustomerMaintenanceController(IModuleController moduleController)
            : base(moduleController) { }

        public void OnDeleteButtonClicked(CustomerEventArgs customerEventArgs)
        {
            throw new NotImplementedException();
        }

        public void OnModifyButtonClicked(CustomerEventArgs customerEventArgs)
        {
            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.ModifyExistingCustomer(customerEventArgs);
        }

        public void OnAddButtonClicked()
        {
            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.AddNewCustomer();
        }

        public void OnGetCustomerButtonClicked(string text)
        {
            if(!IsValidCustomerId(text))
            {
                MessageBox.Show(Resources.InvalidCustomerIDErrorMessage, Resources.InvalidEntryTitle);
                View.SetFocusOnCustomerIdTextBox();
                return;
            }

            var customerId = ParseCustomerId(text);

            var customer = GetCustomerDbo().GetCustomer(customerId);

            try
            {
                View.FillWithCustomerInfo(customer);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(Resources.InvalidCustomerIDErrorMessage, Resources.InvalidCustomerIDTitle);
                View.SetFocusOnCustomerIdTextBox();
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
                return -1;
            }

            return int.Parse(text);
        }

        private CustomerDbo GetCustomerDbo()
        {
            return ModuleController.GetCollection<IDatabaseObjectCollection>().GetDbo<CustomerDbo>();
        }

        protected override void Dispose(bool disposing)
        {    
        }

        
    }
}
