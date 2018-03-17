using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public partial class CustomerMaintenanceForm : Form, ICustomerMaintenanceView
    {
        private CustomerMaintenanceController _controller;
          
        public CustomerMaintenanceForm(CustomerMaintenanceController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public CustomerMaintenanceController Controller {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var addCustomerForm = new AddModifyCustomerForm();
            //DialogResult result = addCustomerForm.ShowDialog();

            Controller.OnAddButtonClicked(new CustomerEventArgs());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Controller.OnModifyButtonClicked(new CustomerEventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.OnDeleteButtonClicked(new CustomerEventArgs());
        }
    }
}
