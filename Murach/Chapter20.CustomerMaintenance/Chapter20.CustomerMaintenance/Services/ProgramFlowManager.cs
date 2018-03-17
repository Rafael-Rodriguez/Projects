using Chapter20.CustomerMaintenance.Views;

namespace Chapter20.CustomerMaintenance.Services
{
    public class ProgramFlowManager : IProgramFlowManager
    {
        private IModuleController _moduleController;

        public ProgramFlowManager(IModuleController moduleController)
        {
            _moduleController = moduleController;
        }

        public void AddNewCustomer()
        {
            var addModifyCustomerForm = _moduleController.GetView<IAddModifyCustomerView>();
            var dialogResult = addModifyCustomerForm.ShowDialog();
        }
    }
}
