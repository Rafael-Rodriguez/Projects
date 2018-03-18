using Chapter20.CustomerMaintenance.Collections;
using Chapter20.CustomerMaintenance.Database;
using Chapter20.CustomerMaintenance.Presentation.Views;
using Chapter20.CustomerMaintenance.Services;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public class CustomerMaintenanceController : Controller<CustomerMaintenanceForm>
    {
        public CustomerMaintenanceController(IModuleController moduleController)
            : base(moduleController) { }

        protected override void OnViewSet()
        { 
            base.OnViewSet();
        }

        public void OnDeleteButtonClicked(CustomerEventArgs customerEventArgs)
        {
            throw new NotImplementedException();
        }

        public void OnModifyButtonClicked(CustomerEventArgs customerEventArgs)
        {
            throw new NotImplementedException();
        }

        public void OnAddButtonClicked(EventArgs eventArgs)
        {
            var programFlowManager = ModuleController.GetService<IProgramFlowManager>();

            programFlowManager.AddNewCustomer();
        }

        public void OnGetCustomerButtonClicked(string text)
        {
            if(!IsValidCustomerID(text))
            {
                MessageBox.Show("Invalid customer ID entered.  Please try again", "Invalid Entry");
                View.SetFocusOnCustomerIDTextBox();
                return;
            }

            var customerID = ParseCustomerID(text);

            var customer = GetCustomerDbo().GetCustomer(customerID);

            try
            {
                View.FillWithCustomerInfo(customer);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Invalid customer id was entered.  Please choose another ID.", "Invalid Customer ID");
                View.SetFocusOnCustomerIDTextBox();
                return;
            }
            
        }

        private bool IsValidCustomerID(string text)
        {
            int resultingNumber;
            if (text != null && int.TryParse(text, out resultingNumber))
            {
                return true;
            }

            return false;
        }
        
        private int ParseCustomerID(string text)
        {
            if(!IsValidCustomerID(text))
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
