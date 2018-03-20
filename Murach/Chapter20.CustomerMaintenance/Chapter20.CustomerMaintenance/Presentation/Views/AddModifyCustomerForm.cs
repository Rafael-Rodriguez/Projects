using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Models;
using System.Collections.Generic;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class AddModifyCustomerForm : Form, IAddModifyCustomerView
    {
        private AddModifyCustomerController _controller;

        public AddModifyCustomerForm(AddModifyCustomerController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public AddModifyCustomerController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                _controller.View = this;
            }
        }

        public Customer Customer { get; set; }

        public void FillStateComboBox(string[] stateCodes)
        {
            comboBoxStates.Items.AddRange(stateCodes);
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            //DialogResult = DialogResult.OK;

            Controller.OnAcceptButtonClicked(new CustomerEventArgs(Customer));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        DialogResult IAddModifyCustomerView.ShowDialog()
        {
            return ShowDialog();
        }

        private void AddModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad();
        }
    }
}
