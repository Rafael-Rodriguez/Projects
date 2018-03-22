using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Services
{
    public class ProgramFlowManager : IProgramFlowManager
    {
        private readonly IModuleController _moduleController;

        public ProgramFlowManager(IModuleController moduleController)
        {
            _moduleController = moduleController;
        }

        public void AddNewCustomer()
        {
            var addCustomerForm = _moduleController.GetView<IAddCustomerView>();
            addCustomerForm.Customer = null;
            var dialogResult = addCustomerForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                var customerMaintenanceForm = _moduleController.GetView<ICustomerMaintenanceView>();
                customerMaintenanceForm.FillWithCustomerInfo(addCustomerForm.Customer);
            }
        }

        public void ModifyExistingCustomer(CustomerEventArgs customerEventArgs)
        {
            var modifyCustomerForm = _moduleController.GetView<IModifyCustomerView>();
            var dialogResult = modifyCustomerForm.ShowDialog(customerEventArgs.Customer);

            if(dialogResult == DialogResult.OK)
            {
                var customerMaintenanceForm = _moduleController.GetView<ICustomerMaintenanceView>();
                customerMaintenanceForm.FillWithCustomerInfo(modifyCustomerForm.Customer);
            }
            else if (dialogResult == DialogResult.Retry)
            {
                var customerMaintenanceForm = _moduleController.GetView<ICustomerMaintenanceView>();
                customerMaintenanceForm.RegrabCustomerInfoFromDb();
            }
        }
    }
}
