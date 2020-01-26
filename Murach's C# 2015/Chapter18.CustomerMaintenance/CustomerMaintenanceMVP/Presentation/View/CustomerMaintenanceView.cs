using CustomerMaintenanceMVP.Presentation.Presenter;
using System.Windows.Forms;

namespace CustomerMaintenanceMVP.Presentation.View
{
    public partial class CustomerMaintenanceView : Form, ICustomerMaintenanceView
    {
        public CustomerMaintenanceView()
        {
            InitializeComponent();
        }

        public MMABooksDataSet DSMMABooks
        {
            get
            {
                return this.mMABooksDataSet;
            }
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            /*this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);*/

            CustomerMaintenancePresenter presenter = new CustomerMaintenancePresenter(this);
            presenter.SaveAllCustomers();

        }

        private void CustomerMaintenanceView_Load(object sender, System.EventArgs e)
        {
            CustomerMaintenancePresenter presenter = new CustomerMaintenancePresenter(this);
            presenter.LoadCustomers();

        }
    }
}
