using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
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
        
        public void SetFocusOnCustomerIdTextBox()
        {
            txtBoxCustomerID.Clear();
            txtBoxCustomerID.Focus();
        }
        
        public void FillWithCustomerInfo(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }


            txtBoxName.Text = customer.Name;
            txtBoxAddress.Text = customer.Address;
            txtBoxCity.Text = customer.City;
            txtBoxState.Text = customer.State.StateName;
            txtBoxZip.Text = customer.ZipCode;
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

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            Controller.OnGetCustomerButtonClicked(txtBoxCustomerID.Text);
        }
    }
}
