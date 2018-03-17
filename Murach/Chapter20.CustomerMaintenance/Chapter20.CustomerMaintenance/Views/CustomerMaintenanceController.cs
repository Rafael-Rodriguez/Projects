using Chapter20.CustomerMaintenance.Services;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
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

        protected override void Dispose(bool disposing)
        {    
        }
    }
}
