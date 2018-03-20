using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public sealed class AddModifyCustomerController : Controller<AddModifyCustomerForm>
    {
        public AddModifyCustomerController(IModuleController moduleController)
            :base(moduleController) { }

        protected override void Dispose(bool disposing)
        {
            
        }
    }
}
