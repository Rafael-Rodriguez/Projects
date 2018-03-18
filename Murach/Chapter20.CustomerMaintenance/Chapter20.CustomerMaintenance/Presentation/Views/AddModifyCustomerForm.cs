using Chapter20.CustomerMaintenance.Presentation.Controllers;
using System;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public partial class AddModifyCustomerForm : Form, IAddModifyCustomerView
    {
        public event EventHandler<CustomerEventArgs> AcceptButtonClicked;
        public event EventHandler<CustomerEventArgs> CancelButtonClicked;

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

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;

            var handler = AcceptButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var handler = CancelButtonClicked;
            handler?.Invoke(this, new CustomerEventArgs());
        }

        DialogResult IAddModifyCustomerView.ShowDialog()
        {
            return ShowDialog();
        }
    }
}
