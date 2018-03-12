using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }
        
        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new frmAddModifyCustomer();
            DialogResult result = addCustomerForm.ShowDialog();
        }
    }
}
