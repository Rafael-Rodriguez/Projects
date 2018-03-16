using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class frmCustomerMaintenance : Form, IView
    {
        public event EventHandler<CustomerEventArgs> AddButtonClicked;
        public event EventHandler<CustomerEventArgs> ModifyButtonClicked;
          
        public frmCustomerMaintenance(IModuleController controller)
        {
            Controller = controller;

            InitializeComponent();
        }

        public IModuleController Controller { get; }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new frmAddModifyCustomer(Controller);
            DialogResult result = addCustomerForm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var handler = ModifyButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }
    }
}
