using Chapter20.CustomerMaintenance.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance
{
    public class ModuleController : IModuleController
    {
        private Dictionary<Forms,IView> _views;

        private AddModifyCustomerForm AddModifyCustomerForm
        {
            get
            {
                return _views[Forms.AddModifyCustomer] as AddModifyCustomerForm;
            }
        }

        private CustomerMaintenanceForm CustomerMaintenanceForm
        {
            get
            {
                return _views[Forms.CustomerMaintenance] as CustomerMaintenanceForm;
            }
        }

        public Form Run()
        {
            RegisterViews();

            RegisterEventHandlers();

            return CustomerMaintenanceForm;
        }

        private void RegisterViews()
        {
            _views = new Dictionary<Forms, IView>
            {
                {Forms.CustomerMaintenance, new CustomerMaintenanceForm(new CustomerMaintenanceController() as IController<IView>)},
                {Forms.AddModifyCustomer, new AddModifyCustomerForm(new AddModifyCustomerController() as IController<IView>)}
            };
        }
        
        private void RegisterEventHandlers()
        {
            CustomerMaintenanceForm.AddButtonClicked += OnAddNewCustomerButtonClicked;
            CustomerMaintenanceForm.ModifyButtonClicked += OnModifyCustomerButtonClicked;
            CustomerMaintenanceForm.DeleteButtonClicked += OnDeleteCustomerButtonClicked;
        }

        private void OnDeleteCustomerButtonClicked(object sender, CustomerEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnModifyCustomerButtonClicked(object sender, CustomerEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnAddNewCustomerButtonClicked(object sender, CustomerEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }

}
