using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class DeleteCustomerForm : Form, IDeleteCustomerView
    {
        private ICustomer _customer;
        private DeleteCustomerController _controller;

        public DeleteCustomerForm(DeleteCustomerController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public DeleteCustomerController Controller
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
            get
            {
                return _customer;
            }

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

        public DialogResult ShowDialog(ICustomer customer)
        {
            Customer = customer;

            return ShowDialog();
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
            Controller.OnAcceptButtonClicked(Customer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad(Customer);
        }
    }
}
