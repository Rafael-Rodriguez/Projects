namespace Chapter20.CustomerMaintenance.Views
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
