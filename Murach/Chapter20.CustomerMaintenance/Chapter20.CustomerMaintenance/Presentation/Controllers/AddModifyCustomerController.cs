using Chapter20.CustomerMaintenance.Presentation.Views;

namespace Chapter20.CustomerMaintenance.Presentation.Controllers
{
    public class AddModifyCustomerController : Controller<AddModifyCustomerForm>
    {
        public AddModifyCustomerController(IModuleController moduleController)
            :base(moduleController) { }

        protected override void OnViewSet()
        {

            base.OnViewSet();
        }

        protected override void Dispose(bool disposing)
        {
            
        }
    }
}
