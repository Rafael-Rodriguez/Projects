using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class CustomerMaintenanceForm : Form, ICustomerMaintenanceView
    {
        private CustomerMaintenanceController _controller;
        private ICustomer _customer;
          
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

        public string NameTextBox { get { return txtBoxName.Text; } }

        public string Address { get { return txtBoxAddress.Text; } }

        public string City { get { return txtBoxCity.Text; } }

        public string State { get { return txtBoxState.Text; } }

        public string ZipCode { get { return txtBoxZip.Text; } }
        
        public void SetFocusOnCustomerIdTextBox()
        {
            txtBoxCustomerID.Clear();
            txtBoxCustomerID.Focus();
        }
        
        public void FillWithCustomerInfo(ICustomer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }


            txtBoxName.Text = customer.Name;
            txtBoxAddress.Text = customer.Address;
            txtBoxCity.Text = customer.City;
            txtBoxState.Text = customer.State;
            txtBoxZip.Text = customer.ZipCode;
            txtBoxCustomerID.Text = customer.CustomerId.ToString();

            _customer = customer;
        }

        public void ClearControls()
        {
            txtBoxName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxCity.Text = "";
            txtBoxState.Text = "";
            txtBoxZip.Text = "";

            SetFocusOnCustomerIdTextBox();

            _customer = null;
        }

        public void RegrabCustomerInfoFromDb()
        {
            Controller.GetCustomerInfo(txtBoxCustomerID.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.OnAddButtonClicked();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Controller.OnModifyButtonClicked(_customer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Controller.OnDeleteButtonClicked(_customer);
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            Controller.OnGetCustomerButtonClicked(txtBoxCustomerID.Text);
        }
    }
}
