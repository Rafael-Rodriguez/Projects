using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class AddCustomerForm : Form, IAddCustomerView
    {
        private AddCustomerController _controller;

        public AddCustomerForm(AddCustomerController controller)
        {
            InitializeComponent();

            Controller = controller;
        }

        public AddCustomerController Controller
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

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            Controller.OnAcceptButtonClicked(
                new NewCustomerEventArgs(
                    address: txtBoxAddress.Text,
                    city: txtBoxCity.Text, 
                    name: txtBoxName.Text, 
                    zipCode: txtBoxZip.Text,
                    state: comboBoxStates.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.OnCancelButtonClicked();
        }

        private void AddModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Controller.OnLoad();
        }

        DialogResult IAddCustomerView.ShowDialog()
        {
            return ShowDialog();
        }
    }
}
