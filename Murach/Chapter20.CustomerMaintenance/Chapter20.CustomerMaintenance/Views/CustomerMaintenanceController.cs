using System;

namespace Chapter20.CustomerMaintenance.Views
{
    public class CustomerMaintenanceController : Controller<CustomerMaintenanceForm>
    {
        protected override void OnViewSet()
        {
            View.AddButtonClicked += OnAddButtonClicked;
            View.ModifyButtonClicked += OnModifyButtonClicked;
            base.OnViewSet();
        }

        private void OnModifyButtonClicked(object sender, CustomerEventArgs customerEventArgs)
        {
            throw new NotImplementedException();
        }

        private void OnAddButtonClicked(object sender, CustomerEventArgs customerEventArgs)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {    
        }
    }
}
