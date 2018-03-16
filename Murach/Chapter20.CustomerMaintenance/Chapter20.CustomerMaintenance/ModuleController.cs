using Chapter20.CustomerMaintenance.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance
{
    public class ModuleController : IModuleController
    {
        private Dictionary<Forms,IView> _views;

        public Form Run()
        {
            RegisterViews();

            return GetFirstView();
        }

        private void RegisterViews()
        {
            _views = new Dictionary<Forms, IView>
            {
                {Forms.CustomerMaintenance, new frmCustomerMaintenance(this)},
                {Forms.AddModifyCustomer, new frmAddModifyCustomer(this)}
            };
        }

        private Form GetFirstView()
        {
            return _views[Forms.CustomerMaintenance] as Form;
        } 
        
    }

}
