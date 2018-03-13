using Chapter20.CustomerMaintenance.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance
{
    public class DomainController : IDomainController
    {
        private Dictionary<Forms,IView> _views;

        public Form Run()
        {
            RegisterViews();

            return GetFirstView();
        }

        private void RegisterViews()
        {
            _views = new Dictionary<Forms, IView>();
            _views.Add(Forms.CustomerMaintenance, new frmCustomerMaintenance(this));
            _views.Add(Forms.AddModifyCustomer, new frmAddModifyCustomer(this));
        }

        private Form GetFirstView()
        {
            return _views[Forms.CustomerMaintenance] as Form;
        } 
        
    }

}
