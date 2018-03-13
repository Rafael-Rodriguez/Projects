using Chapter20.CustomerMaintenance.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Controller
{
    public class Controller : IController
    {
        private List<IView> _views;

        public Form Run()
        {
            RegisterViews();

            return GetFirstView();
        }

        private void RegisterViews()
        {
            _views = new List<IView>();
            _views.Add(new frmCustomerMaintenance(this));
            _views.Add(new frmAddModifyCustomer(this));
        }

        private Form GetFirstView()
        {
            return _views[0] as Form;
        } 
        
    }

}
