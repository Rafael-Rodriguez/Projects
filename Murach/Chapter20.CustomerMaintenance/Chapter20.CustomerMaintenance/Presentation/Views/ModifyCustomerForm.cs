using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class ModifyCustomerForm : Form, IModifyCustomerView
    {
        private ModifyCustomerController _controller;
        private ICustomer _customer;

        public ModifyCustomerForm(ModifyCustomerController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public ModifyCustomerController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        public ICustomer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                FillCustomerFields(_customer);
            }
        }

        public IList<string> States
        {
            get
            {
                return comboBoxStates.Items.Cast<string>().ToList();
            }
        }

        public void FillStateComboBox(string[] states)
        {
            comboBoxStates.Items.AddRange(states);
        }

        public void SetDialogResult(DialogResult result)
        {
            DialogResult = result;
        }

        private void FillCustomerFields(ICustomer customer)
        {
            txtBoxName.Text = customer.Name;
            txtBoxAddress.Text = customer.Address;
            txtBoxCity.Text = customer.City;
            comboBoxStates.Text = Controller.ConvertStateCodeToStateName(customer.State);
            txtBoxZip.Text = customer.ZipCode;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Controller.OnAcceptButtonClicked(Customer, 
                new Customer
                {
                    Address =  txtBoxAddress.Text,
                    City = txtBoxCity.Text,
                    Name = txtBoxName.Text,
                    State = Controller.ConvertStateNameToStateCode(comboBoxStates.Text),
                    ZipCode = txtBoxZip.Text
                }
                );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        DialogResult IModifyCustomerView.ShowDialog(ICustomer customer)
        {
            Customer = customer;

            return ShowDialog();
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad(Customer);
        }
    }
}
