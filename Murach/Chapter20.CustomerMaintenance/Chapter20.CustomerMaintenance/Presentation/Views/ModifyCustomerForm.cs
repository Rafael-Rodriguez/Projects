using Chapter20.CustomerMaintenance.Models;
using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class ModifyCustomerForm : Form, IAddCustomerView
    {
        private ModifyCustomerController _controller;

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

        public Customer Customer { get; set; }

        public void FillStateComboBox(string[] states)
        {
            comboBoxStates.Items.AddRange(states);
        }

        internal void FillCustomerInfo(CustomerEventArgs customerEventArgs)
        {
            txtBoxName.Text = customerEventArgs.Customer.Name;
            txtBoxAddress.Text = customerEventArgs.Customer.Address;
            txtBoxCity.Text = customerEventArgs.Customer.City;
            comboBoxStates.SelectedText = customerEventArgs.Customer.State;
            txtBoxZip.Text = customerEventArgs.Customer.ZipCode;
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            Controller.OnAcceptButtonClicked();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        private void AddModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad(new CustomerEventArgs(Customer));
        }

        DialogResult IAddCustomerView.ShowDialog()
        {
            return ShowDialog();
        }
    }
}
